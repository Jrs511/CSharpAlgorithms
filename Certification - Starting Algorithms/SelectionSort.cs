using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification___Starting_Algorithms
{
    internal class SelectionSort
    {
        public static void Selection_Sort(int[] SelArray)
        {
            int max = SelArray.Length;

            // Used to itterate through each member of the unsorted array 
            for (int i = 0; i < max; i++)
            {
                // Used to find the minimum of the array 
                int minIndex = i;
                for (int j = i + 1; j < max; j++)
                {
                    if (SelArray[j] < SelArray[minIndex])
                        minIndex = j;
                }
                // used to swap the minimum element with the first element of the array
                int temp = SelArray[minIndex];
                SelArray[minIndex] = SelArray[i];
                SelArray[i] = temp;
            }
        }
    }
}
