# 📊 Sorting Algorithms Benchmark – Faculty Project

This C# console application benchmarks three sorting algorithms — **Insertion Sort**, **Iterative Merge Sort**, and **Bucket Sort** — across various input sizes. It calculates the **minimum difference** between elements in sorted subarrays and displays both **execution time** and **memory usage**.

---

## 🛠️ Algorithms Implemented

- **Insertion Sort**  
  Classic O(n²) algorithm, suitable for small datasets.
  
- **Iterative Merge Sort**  
  An O(n log n) divide-and-conquer sorting method without recursion.

- **Bucket Sort**  
  Efficient for uniformly distributed data. Uses Insertion Sort within each bucket.

---

## 🧪 Performance Test Setup

- Input sizes tested:  
  `100`, `1,000`, `10,000`, `100,000`, `1,000,000`, and `10,000,000`

- For each array:
  - Random integers in the range `1` to `10,000` are generated.
  - A subarray of size `m = 30%` of the array is selected.
  - The minimum difference between the largest and smallest values in a sorted subarray of size `m` is computed.

- Benchmarked using:
  - `Stopwatch` for timing
  - `.PrivateMemorySize64` and `GC.GetTotalMemory(false)` for memory usage


