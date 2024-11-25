//Given an array of size n, find the majority element. The majority element is the element that appears more than n/2 times.
    //Example: Input: [3, 2, 3] → Output: 3

namespace MajorityElement
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 3 };
            int majorityElement = FindMajorityElement(arr);

            if (majorityElement != -1)
            {
                Console.WriteLine("Majority Element: " + majorityElement);
            }
            else
            {
                Console.WriteLine("No majority element found.");
            }
        }
        // Method to find the majority element
        static int FindMajorityElement(int[] arr)
        {
            int n = arr.Length;

            // Brute-force approach to check every element
            for (int i = 0; i < n; i++)
            {
                int count = 0;

                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                // If the count is more than n/2, return the majority element
                if (count > n / 2)
                {
                    return arr[i];
                }
            }
            // If no majority element found, return -1
            return -1;
        }
    }
}
