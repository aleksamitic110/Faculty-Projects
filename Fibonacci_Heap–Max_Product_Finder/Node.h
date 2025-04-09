#pragma once
//Classes
class Node {
public:
    int key;
    int degree;
    bool mark;
    Node* parent;
    Node* child;
    Node* left;
    Node* right;


    Node(int val) {
        key = val;
        degree = 0;
        mark = false;
        parent = nullptr;
        child = nullptr;
        left = this;
        right = this;
    }
};

