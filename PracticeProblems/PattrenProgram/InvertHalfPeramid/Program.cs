//convert the set of code int comment using ctrl k+c, to uncomment ctrl k+u
namespace InvertHalfPeramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int i, j, n = 4;
            //for (i = 0; i <= n; i++)
            //{
            //    for (j = n; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //One more method we can do this
            //for (i=n; i>=1; i--)
            //{
            //    for (j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //to reverse the code
            for (i = 0; i<=n; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        } 
    }
}
