namespace patternSquare
{
    internal class Program
    {
        static void Main()
        {
            int i, j, n = 6;
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= n; j++)
                {
                    if(i==0 || j==0 || j== n-i || i==j || i==n || j==n) Console.Write("*"+" ");
                    else Console.Write(" "+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
