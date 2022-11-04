using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification___Starting_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Binary Search");
            //int[] binArray = { 1, 4, 7, 9, 11 };
            //Console.WriteLine(BinarySearch.Binary_Search(binArray, 9));
            //
            //
            //int[] linArray = { 1, 4, 7, 9, 11 };
            //int temp = LinearSearch.Linear_Search(linArray, 4);
            //Console.WriteLine("Linear Search");
            //if (temp == -1)
            //    Console.WriteLine("Number not found in array");
            //else 
            //    Console.WriteLine($"number is at index {temp}");
            //Console.WriteLine("Bubble Sort");
            //
            //
            //int[] bubArray = { 5, 27, 11, 67, 2 };
            //BubbleSort.Bubble_Sort(bubArray);
            //Console.WriteLine($"Sorted Array");
            //int n = bubArray.Length;
            //for (int i = 0; i < n; ++i)
            //    Console.Write(bubArray[i] + " ");
            //Console.ReadLine();

            int[] SmallArray = { 5, 15, 3, 27, 1 };
            int[] MediumArray = { 5, 15, 3, 27, 3, 8, 26, 4, 11, 17 };
            int[] BigArray = { 5, 15, 3, 27, 3, 8, 26, 4, 11, 17, 19, 1, 29, 24, 23 };
            int[] HellaBigArray = { 5, 15, 3, 27, 3, 8, 26, 4, 11, 17, 19, 1, 29, 24, 23, 2, 69, 112, 57, 29 };
            int[] HugeArray = { 5, 15, 3, 27, 3, 8, 26, 4, 11, 17, 19, 1, 29, 24, 23, 2, 69, 112, 57, 29, 115, 270, 236, 1234, 62 };

            //int w = BigArray.Length;
            //
            //QuickSort.quickSort(BigArray, 0, w - 1);
            //int n = BigArray.Length;
            //for (int i = 0; i < n; ++i)
            //   Console.Write(BigArray[i] + " ");



            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            Mergesort.sort(HugeArray, 0, HugeArray.Length - 1);
            int n = HugeArray.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(HugeArray[i] + " ");

            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.Elapsed} ms");
            Console.ReadLine();

        }
    }

}
