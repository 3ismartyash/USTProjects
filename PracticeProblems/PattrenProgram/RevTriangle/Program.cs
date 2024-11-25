namespace RevTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n = 5;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (k = 2 * (n - i) - 1; k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
