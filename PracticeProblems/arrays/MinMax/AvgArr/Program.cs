namespace AvgArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int n = arr.Length, sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            int ans = sum / n;
            Console.WriteLine("The Avarage of the array is: " + ans);
        }
    }
}
