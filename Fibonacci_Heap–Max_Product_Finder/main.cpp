#include <iostream>
#include <cmath>
#include <vector>
#include <limits>
#include <cstdlib>
#include <queue>
#include <utility>
#include <stack>

#include "Node.h"
#include "FibonacciHeap.h"
using namespace std;




//---------------------------------FUNCTIONS-----------------
int randomNumber(int low, int high) {
    return low + rand() % (high - low + 1);
}


int fillHeap(FibonacciHeap* heap, int N, int a, int b, int k, int arr[]) { //Adding elements to heap and extracting evry K-th element
    int countK = 0;
    int indexOfArr = 0;

    //Filling heap and array that will be used for sorting and findng k max product
    for (int i = 0; i < N; i++) {
        int rand = randomNumber(a, b);
        heap->insert(rand);
        countK++;
        if (countK == k) {
            heap->extractMin();
            countK = 0;
        }
        else
            arr[indexOfArr++] = rand;
    }
    return indexOfArr;
}
void findK_maxProducts(int arr[], int numOFElements, int k, int p) { //Finding k maximum products using p numbers

    int x = numOFElements - p + 1;
    unsigned long long maxItteration = 0;

    while (x != 0) { // Finding max itterations
        maxItteration += x;
        x--;
    }

    if (maxItteration < k)
    {
        cout << "K is too big!" << endl;
        return;
    }

    unsigned long long int max; //Must be long long unsigned so it can fit all products (still a lot of bigger ones cant be done)
    int copyK = k;

    int numOfRepeats = 0;
    int numProduct = 1;

    //Iterating trough sorted array and finding current max product of (p - 1) elements
    for (int i = 0; i < maxItteration; i++) {

        max = 1;
        int numOfTimes = 0;

        cout << endl << "Current (p - 1) max elements: ";
        for (int j = numOFElements - 1 - numOfRepeats; numOfTimes < p - 1; j--) {
            max *= arr[j];
            numOfTimes++;
            cout << arr[j] << " ";
        }

        cout << endl;

        //Going trough rest of elements and multiplaying them with max product of (p - 1) elemnts so we get p elements in product
        for (int z = numOFElements - p - numOfRepeats; z >= 0; z--) {
            unsigned long long produtc = max * arr[z]; //unsigned long long because of product being too big
            cout << numProduct << ".\t Max product: " << max << " * " << arr[z] << " = " << produtc << endl;
            numProduct++;
            copyK--;
            if (copyK == 0)
                break;
        }
        if (copyK == 0)
            break;
        numOfRepeats++;
    }
}

//Qucik sort algorithm
int divideArr(int arr[], int leftEnd, int rightEnd) {
    int pivot = arr[rightEnd];
    int i = leftEnd - 1;

    for (int j = leftEnd; j < rightEnd; j++) {
        if (arr[j] <= pivot) {
            i++;
            if (arr[i] != arr[j]) {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    int temp = arr[i + 1];
    arr[i + 1] = arr[rightEnd];
    arr[rightEnd] = temp;

    return i + 1;
}
void quickSort(int arr[], int leftEnd, int rightEnd) {
    if (leftEnd < rightEnd) {
        int middle = divideArr(arr, leftEnd, rightEnd);
        quickSort(arr, leftEnd, middle - 1);
        quickSort(arr, middle + 1, rightEnd);
    }
}
void quickSortIterative(int arr[], int l, int h) {
    stack<pair<int, int>> s;
    s.push({ l, h });

    while (!s.empty()) {
        auto [start, end] = s.top();
        s.pop();

        if (start < end) {
            int p = divideArr(arr, start, end);
            s.push({ start, p - 1 });
            s.push({ p + 1, end });
        }
    }
}

//----------------------MAIN-------------------------------------
int main() {

    srand(time(NULL));
    FibonacciHeap heap;
    int a = 1, b = 2000, k = 100, p = 4;
    const int N = 1000;
    int kFreq = 10;
    int arr[N], numOfElements;

    cout << "Filling heap...." << endl;
    numOfElements = fillHeap(&heap, N, a, b, kFreq, arr);
    cout << "Heap filled" << endl << endl;

    //Sorting array
    quickSortIterative(arr, 0, numOfElements - 1);

    //Finding and printing max products
    findK_maxProducts(arr, numOfElements, k, p);

    return 0;
}
