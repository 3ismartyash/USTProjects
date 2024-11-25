//Given an unsorted array of integers, find the length of the longest consecutive elements sequence.
    //Example: Input: [100, 4, 200, 1, 3, 2] → Output: 4(sequence is [1, 2, 3, 4])

namespace LongestConsecutiveSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= {100,4,200,1,3,2}; //1,2,3,4,100,200
            Array.Sort(arr);
            int n = arr.Length;
            int count = 1;
            for (int i = 1; i <= n-1; i++)
            {
                if (arr[i] == arr[i-1]+1)
                    count++;
            }
            Console.WriteLine(count);

            //int[] arr = { 100, 4, 200, 1, 3, 2 }; // Example array
            //Array.Sort(arr);                      // Sort the array
            //int n = arr.Length;

            //int maxLength = 1;                    // To track the length of the longest sequence
            //int currentLength = 1;                // To track the current consecutive sequence

            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] == arr[i - 1] + 1)       // Check if current element is consecutive
            //    {
            //        currentLength++;               // Increase current sequence length
            //    }
            //    else if (arr[i] != arr[i - 1])       // If not consecutive and not a duplicate
            //    {
            //        maxLength = Math.Max(maxLength, currentLength); // Update max length
            //        currentLength = 1;             // Reset for new sequence
            //    }
            //}

            //// Final check to update maxLength in case the longest sequence was at the end
            //maxLength = Math.Max(maxLength, currentLength);

            //Console.WriteLine("The length of the longest consecutive sequence is: " + maxLength);
        }
    }
}
