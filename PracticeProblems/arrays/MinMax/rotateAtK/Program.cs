﻿//Given an array, rotate it to the right by k steps, where k is a non-negative integer.
    //Example: Input: [1, 2, 3, 4, 5, 6, 7], k = 3 → Output: [5, 6, 7, 1, 2, 3, 4]
namespace rotateAtK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7};
            int k = 3;
            for (int i = k+1 ; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            for (int i = 0; i <= k; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
