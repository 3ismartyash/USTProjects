namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n = 3;
            for (i = n; i >= 1; i--)
            {
                for (j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = 2; i <=n; i++)
            {
                for (j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            

        }
    }
}
