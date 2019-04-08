using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleScratch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 15, 18, 20, 21, 22, 23, 24, 25, 26, 30, 40, 55, 86, 100 };
            Console.WriteLine(binarySearch(sortedArray, 11));
           

        }

        static int binarySearch(int[] Array, int value)
        {
            int len = Array.Length; //Length of our sorted array
            int mid = (len / 2);

            if (value == Array[mid])
            {
                return Array[mid];
            }

            bool valueGtMid = value > Array[mid];

            for(int i = valueGtMid ? mid:0; i <= len - 1; i++)
            {
                if (value == Array[i])
                {
                    return Array[i];
                }
            }


            return -1;
        }
    }
}
