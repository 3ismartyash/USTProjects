//Given an array consisting of only 0s, 1s, and 2s, sort the array in linear time.
//Example: Input: [2, 0, 2, 1, 1, 0] → Output: [0, 0, 1, 1, 2, 2]

namespace SortAnArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 0, 2, 1, 1, 0 };
            Array.Sort(arr);
            Console.Write('['+string.Join(",",arr)+']');
        }
    }
}
