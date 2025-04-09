# Fibonacci Heap – Max Product Finder

## 📚 Project Description

This C++ project demonstrates the use of the **Fibonacci heap** data structure for processing a large set of random numbers and solving the problem of finding the **k largest products** from a sequence of numbers.

The project includes:
- Implementation of a **Fibonacci heap** (a highly optimized structure for priority queue operations)
- Fast sorting (**QuickSort**, including an iterative version)
- Random number generation
- Computation of **k largest products** using **p numbers** from the array

---

### ✅ Fibonacci Heap – Operations

- `insert(val)`: Inserts a new node into the root list.
- `extractMin()`: Removes the node with the minimum value and consolidates the heap.
- `link()`: Links two trees of the same degree.
- Internally uses the `consolidate()` method to maintain structure
  
The Fibonacci heap allows for efficient implementation of `insert`, `extractMin`, and `decreaseKey` operations, making it especially useful for minimum-priority-based algorithms.

---

### ⚙️ QuickSort – Iterative Version

The function `quickSortIterative()` uses a `stack<pair<int, int>>` to simulate recursive sorting without function call overhead, reducing memory usage and preventing stack overflow.


