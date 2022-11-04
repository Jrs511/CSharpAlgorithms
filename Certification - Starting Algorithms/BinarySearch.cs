using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification___Starting_Algorithms
{
    internal class BinarySearch
    {
        public static object Binary_Search(int[] BinArray, int key)
        {
            // Sorts the array
            Array.Sort(BinArray);
            // sets the min to 0
            int min = 0;
            // sets the max to the length of the array minus 1
            int max = BinArray.Length - 1;
            // While loop that runs while min is less than or equal too max
            while (min <= max)
            {
                // sets mid to min plus max divided by 2
                int mid = (min + max) / 2;
                // if the key is equal to the middle of the Binary Array it returns the matching index
                if (key == BinArray[mid])
                {
                    return mid++;
                }
                // if the key is less than the middle of BinArray it makes the new max the mid minus one so that it checks the to the left of the array
                else if (key < BinArray[mid])
                {
                    max = mid - 1;
                }
                // Runs if none others are true and changes the min to the current mid plus 1
                else
                {
                    min = mid + 1;
                }
            }
            // returns nill if the key does not exist in the array
            return "Nil";
        }
    }
}
