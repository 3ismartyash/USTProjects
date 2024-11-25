//You are given an array containing n distinct numbers in the range 0 to n. Find the one missing number.
//Example: Input: [3, 0, 1] → Output: 2
namespace MissingNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 0, 1, };
            int max = arr.Max();
            int expectedSum = (max * (max + 1)) / 2;
            int actualSum=0;
            foreach (int num in arr)
            {
                actualSum+=num;
            }

            int ans = expectedSum - actualSum;
            Console.WriteLine(ans);
        }
    }
}                 
