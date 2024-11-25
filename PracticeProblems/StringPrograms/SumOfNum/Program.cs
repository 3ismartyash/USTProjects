namespace SumOfNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputstring = "SRISAI333";
            int sum = 0;

            char[] charArr = inputstring.ToCharArray();

            foreach (char character in charArr)
            {
                if (char.IsDigit(character))
                {
                    sum += int.Parse(character.ToString());
                }
            }
            Console.WriteLine(sum);

        }
    }
}
