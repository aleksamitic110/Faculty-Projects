using System.Diagnostics;


	internal class Program {
	//---------------------------------------- ALGORITHMS -----------------------------------------------------------------------------------------------------
	static void InsertionSort(List<int> arr) // Insertion Sort
	{
		int current, j;
		for (int i = 1; i < arr.Count; i++)
		{
			current = arr[i];
			j = i - 1;

			while (j >= 0 && arr[j] > current)
			{
				arr[j + 1] = arr[j];
				j = j - 1;
			}
			arr[j + 1] = current;
		}
	}

	// Iterative Merge Sort
	static void Merge(List<int> arr, int left, int mid, int right)
	{
		//Lengths of left and right subarray
		int nL = mid - left + 1;
		int nR = right - mid;

		//Subarray left and right
		List<int> Left = new List<int>();
		List<int> Right = new List<int>();

		//Filling subarrays 
		for (int i = 0; i < nL; i++)
			Left.Add(arr[left + i]);
		for (int j = 0; j < nR; j++)
			Right.Add(arr[mid + 1 + j]);

		//Indexes for traversing left and right subarrays
		int l = 0, r = 0, k = left;

		//Merging elements in arr
		while (l < nL && r < nR)
		{
			if (Left[l] <= Right[r])
			{
				arr[k] = Left[l];
				l++;
			}
			else
			{
				arr[k] = Right[r];
				r++;
			}
			k++;
		}

		//If some of elements are still not sorted 
		while (l < nL)
		{
			arr[k] = Left[l];
			l++;
			k++;
		}

		while (r < nR)
		{
			arr[k] = Right[r];
			r++;
			k++;
		}
	}
	static void IterativeMergeSort(List<int> arr)
	{

		int n = arr.Count;
		for (int size = 1; size < n; size = 2 * size)
		{
			for (int left = 0; left < n - 1; left += 2 * size)
			{
				//Calcutaion of mid and right for each divided cell
				int mid = Math.Min(left + size - 1, n - 1);
				int right = Math.Min(left + 2 * size - 1, n - 1);

				if (mid < right)
					Merge(arr, left, mid, right);
			}
		}
	}

	static void BucketSort(int[] arr) // Bucket Sort
	{
		int n = arr.Length;

		//Create n buckets
		List<int>[] buckets = new List<int>[n];
		for (int i = 0; i < n; i++)
			buckets[i] = new List<int>();

		//Fill buckets with elements
		int maxValue = arr.Max();
		for (int i = 0; i < n; i++)
		{
			int bucketIndex = (int)((float)n * arr[i] / (maxValue + 1)); // Range from 0 to n - 1
			buckets[bucketIndex].Add(arr[i]);
		}

		//Sorting all buckets
		for (int i = 0; i < n; i++)
			InsertionSort(buckets[i]);

		// Merge all buckets 
		int index = 0;
		for (int i = 0; i < n; i++)
			for (int j = 0; j < buckets[i].Count; j++)
				arr[index++] = buckets[i][j];
	}

	//--------------------------------------- CALCULATION -----------------------------------------------------------------------------------------------------------
	static int FindMinDifferenceUsingSort(List<int> arr, int m, Action<List<int>, int> sortFunction)
	{
		sortFunction(arr, arr.Count);
		int minDifference = int.MaxValue;

		for (int i = 0; i <= arr.Count - m; i++)
		{
			int difference = arr[i + m - 1] - arr[i];
			if (difference < minDifference)
				minDifference = difference;
		}

		return minDifference;
	}
	static void FillListWithRandomNumbers(List<int> arr, int size)//Filling list with random numbers from 0-10k
	{
		Random rand = new Random();
		for (int i = 0; i < size; i++)
			arr.Add(rand.Next(1, 10000));
	}

	//---------------------------------------- MAIN ---------------------------------------------------------------------------------------------------------------
	static void Main()
	{

		//Creating list of sizes M
		List<int> sizes = new List<int> { 100, 1000, 10000, 100000, 1000000, 10000000 };
		List<int> mValues = new List<int>();

		//Creating all arrays and filling them with random values from 0-10k
		List<List<int>> arrays = new List<List<int>>();
		foreach (int size in sizes)
		{
			var arr = new List<int>();
			FillListWithRandomNumbers(arr, size);
			arrays.Add(arr);
			mValues.Add((int)(0.3 * size));
		}

		//Do Calculations and mesure times and memory usage
		Console.WriteLine("What calculation do you want to start?");
		Console.WriteLine("[0 - exit] [1 - Bucket Sort] [2 - Iterative Merge Sort] [3 - Insertion Sort]: ");
		char choice = Console.ReadLine()[0];

		while (choice != '0')
		{
			Process currentProcess = Process.GetCurrentProcess(); //Mesuring private memory

			Action<List<int>, int> sortFunction = null;
			string sortName = "";

			if (choice == '1')
			{ //Bucket sort

				sortFunction = (List<int> arr, int n) => // Assign the BucketSort to sortFunction
				{
					// Convert List<int> to int[] and call BucketSort
					int[] arrArray = arr.ToArray();
					BucketSort(arrArray);
					arr.Clear();
					arr.AddRange(arrArray);
				};
				sortName = "BUCKET SORT";
			}
			else if (choice == '2')
			{ //Iterative merge sort
				sortFunction = (List<int> arr, int n) => IterativeMergeSort(arr);
				sortName = "ITERATIVE MERGE SORT";
			}
			else if (choice == '3')
			{ //Insertion sort
				sortFunction = (List<int> arr, int n) => InsertionSort(arr);
				sortName = "INSERTION SORT";
			}
			else
			{
				Console.WriteLine("Error input!!!");
				choice = Console.ReadLine()[0];
				continue;
			}

			//Show results of sorting and calculations

			Console.WriteLine($"\nCalculating using {sortName}...");
			for (int i = 0; i < arrays.Count; i++) // do all arr sorting and find minDif for every arr size
			{
				//Making copy so it doesnt get sorted for next use
				List<int> arrayCopy = new List<int>(arrays[i]);

				//Startin stopwatch
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				int minDifference = FindMinDifferenceUsingSort(arrayCopy, mValues[i], sortFunction);
				stopwatch.Stop();


				long memoryUsage = GC.GetTotalMemory(false);
				//Output results
				Console.WriteLine($"Arr[{sizes[i],-8}] -> minDiff: {minDifference,-8} -> Time: {stopwatch.ElapsedMilliseconds,5} ms -> " +
								  $"PrivateMemory: {currentProcess.PrivateMemorySize64 / (1024 * 1024),4} MB -> " +
								  $"TotalMemoryUsage: {memoryUsage / (1024 * 1024),4} MB");
			}

			//Get total memory usage and start again
			Console.WriteLine($"WorkingSet: {currentProcess.WorkingSet64 / (1024 * 1024),4} MB");

			Console.WriteLine("\nWhat calculation do you want to start?");
			Console.WriteLine("[0 - exit] [1 - Bucket Sort] [2 - Iterative Merge Sort] [3 - Insertion Sort]: ");
			choice = Console.ReadLine()[0];
		}
	}
}


