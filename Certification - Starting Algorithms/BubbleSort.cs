using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification___Starting_Algorithms
{
    internal class BubbleSort
    {
        public static void Bubble_Sort(int[] bubArray)
        {
            // Sets the max to the length of the array
            int max = bubArray.Length;
            // For loop that iterates that is used to make run another for loop that iterates through the array
            for (int i = 0; i < max - 1; i++)
                // Used to iterate through bubArray
                for (int j = 0; j < max - i - 1; j++)
                    // if statement that checks if the object at bubArray[j] is greater than the object at the next index position, if it is it then swaps the two
                    if (bubArray[j] > bubArray[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = bubArray[j];
                        bubArray[j] = bubArray[j + 1];
                        bubArray[j + 1] = temp;
                    }
        }
    }
}
