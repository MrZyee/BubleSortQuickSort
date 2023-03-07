using System;
using System.Diagnostics;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bubbleSortValue = 0;
            double quickSortValue = 0;
            Stopwatch stopwatch = new Stopwatch();
            int[] arr = { 1, 2, 5, 3, 1, 7, 9, 1, 12, 83, 1, 5, 3, 2 };
            


            stopwatch.Start();
            //bubblesort
            BubbleSort(arr);
            stopwatch.Stop();
            bubbleSortValue = stopwatch.ElapsedMilliseconds;

            stopwatch.Reset();

            stopwatch.Start();
            //Quicksort
            QuickSort(arr, 0, arr.Length - 1);
            stopwatch.Stop();
            quickSortValue = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Bubblesort: {bubbleSortValue}");
            Console.WriteLine($"QuickSort: {quickSortValue}");
        }

        public static void BubbleSort(int[] arr)
        {
            int temp = 0;
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
        public static void QuickSort(int[] array, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = array[(left + right) / 2];
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    var tmp = array[i];
                    array[i++] = array[j];
                    array[j--] = tmp;
                }
            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);

        }
    }
}