using System.Text.Json.Nodes;

namespace RevInvertedHalfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n = 4;
            //for (i = 0; i <= n; i++)
            //{
            //    for (j = 0; j < n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // To reverse the same code
            for (i = n; i >=0; i--)
            {
                for (j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
