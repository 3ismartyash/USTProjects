//Given an array nums, return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].
//Example: Input: [1, 2, 3, 4] → Output: [24, 12, 8, 6]

namespace ProductExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int n=arr.Length;
            int product = 1;
            int[] ans = new int[n];
            foreach (int num in arr)
            {
                product *= num;
            }
            for (int i = 0; i < n;i++)
            {
                ans[i] = product / arr[i];
            }
            Console.Write(string.Join(", ", ans));
        }
    }
}
