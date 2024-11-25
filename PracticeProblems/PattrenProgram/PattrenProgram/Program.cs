namespace PattrenProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n = 3;
            for(i=1; i<=n; i++)
            {
                for(j=1; j<=i-1; j++)
                {
                    Console.Write(" ");
                }
                for(j=1 ; j<= 2*(n-i) +1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
