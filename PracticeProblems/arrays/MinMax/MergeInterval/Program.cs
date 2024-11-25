//Find the kth largest element in an unsorted array.
    //Example: Input: [3, 2, 1, 5, 6, 4], k = 2 → Output: 5

namespace KThLargest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1, 5, 6, 4};
            int n = arr.Length;
            int k = 2;
            Array.Sort(arr);
            Console.Write(arr[n-k]);
        }
    }
}
