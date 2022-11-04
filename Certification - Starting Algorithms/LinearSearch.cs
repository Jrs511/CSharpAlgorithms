using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification___Starting_Algorithms
{
    internal class LinearSearch
    {
        public static int Linear_Search(int[] linArray, int Key)
        {
            // Sets the max number in the array so that the for loop can iterate through it
            int max = linArray.Length;
            // For loop that is used to iterate through the array
            for(int i = 0; i < max; i++)
            {
                //checks if the array at the index of I is equal to the key and if it is it returns the index position 
                if (linArray[i] == Key)
                    return i;
            }
            //returns -1 if the key is not in the array
            return -1;
        }
    }
}
