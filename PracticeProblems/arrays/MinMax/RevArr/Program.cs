namespace RevArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            int n = arr.Length;
            for (int i = n-1; i>=0; i--)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
