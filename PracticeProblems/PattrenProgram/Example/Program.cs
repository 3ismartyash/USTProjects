namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n = 6;
            for (i = 0; i <=n; i++)
            {
                for (j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0 || i == n - j || i == j || i == n || j == n)
                    {
                        Console.Write("*" + " ");
                    }
                    else
                    {
                        Console.Write(" " + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
