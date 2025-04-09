#pragma once
#include <iostream>
#include <cmath>
#include <vector>
#include <limits>
#include <cstdlib>
#include <queue>


using namespace std;

#include "Node.h"
class FibonacciHeap {
private:
    Node* mini;
    int noOfNodes;

    // Linking nodes 
    void link(Node* y, Node* x) {
        y->left->right = y->right;
        y->right->left = y->left;

        y->parent = x;
        if (x->child == nullptr) {
            x->child = y;
            y->left = y;
            y->right = y;
        }
        else {
            y->left = x->child;
            y->right = x->child->right;
            x->child->right->left = y;
            x->child->right = y;
        }

        x->degree++;
        y->mark = false;
    }

    // Update function
    void consolidate() {
        long maxDegree = (std::log(noOfNodes) / std::log(2)) + 1;

        if (maxDegree <= 0)
            return;

        vector<Node*> degreeTable(maxDegree + 10000, nullptr);

        auto helperList = mini;

        vector<Node*> rootNodes;
        Node* current = mini;

        // Collect all nodes in the root list
        do {
            rootNodes.push_back(current);
            current = current->right;
        } while (current != mini);

        for (auto root : rootNodes) {
            auto rootDeg = root->degree;

            while (degreeTable[rootDeg]) {
                auto helperNode = degreeTable[rootDeg];
                if (root->key > helperNode->key)
                    std::swap(root, helperNode);

                link(helperNode, root);
                degreeTable[rootDeg++] = nullptr;
            }

            degreeTable[rootDeg] = root;
        }

        mini = nullptr;

        for (int i = 0; i < maxDegree; ++i) {
            if (degreeTable[i]) {
                if (std::find(rootNodes.begin(), rootNodes.end(), degreeTable[i]) == rootNodes.end())
                    rootNodes.push_back(degreeTable[i]);

                if (!mini || degreeTable[i]->key < mini->key)
                    mini = degreeTable[i];
            }
        }

        // Rebuild the root list with the consolidated nodes
        mini = nullptr;
        for (auto root : rootNodes) {
            if (!mini) {
                mini = root;
                root->left = root;
                root->right = root;
            }
            else {
                root->left = mini->left;
                mini->left->right = root;
                root->right = mini;
                mini->left = root;
            }
        }
    }

public:
    // Constructor
    FibonacciHeap() {
        mini = nullptr;
        noOfNodes = 0;
    }

    // Adding nodes to heap
    void insert(int val) {
        Node* newNode = new Node(val);
        if (mini != nullptr) {
            (mini->left)->right = newNode;
            newNode->right = mini;
            newNode->left = mini->left;
            mini->left = newNode;
            if (newNode->key < mini->key) {
                mini = newNode;
            }
        }
        else {
            mini = newNode;
        }
        noOfNodes++;
    }

    // Extracting node with minimum value
    int extractMin() {
        if (noOfNodes == 0 || !mini)
            return std::numeric_limits<int>::min();

        auto extractedMin = mini;

        // Put all children from extracted node in root list
        if (extractedMin->child != nullptr) {
            Node* child = extractedMin->child;
            do {
                Node* nextChild = child->right;

                // Add child to the root list
                child->left = mini->left;
                mini->left->right = child;
                child->right = mini;
                mini->left = child;

                child->parent = nullptr;
                child = nextChild;
            } while (child != extractedMin->child);
        }

        // Delete extractedMin from root list
        extractedMin->left->right = extractedMin->right;
        extractedMin->right->left = extractedMin->left;

        //Consolidate heap
        if (extractedMin == extractedMin->right)
            mini = nullptr;
        else {
            mini = extractedMin->right;
            consolidate();
        }

        noOfNodes--;
        int key = extractedMin->key;
        delete extractedMin;

        return key;
    }
};

