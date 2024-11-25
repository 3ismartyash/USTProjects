using System.Text;

namespace CharAndWordReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            Console.WriteLine("Input: " + input);

            string[] words = input.Split(' ');
            Array.Reverse(words);

            StringBuilder output = new StringBuilder();

            foreach (string word in words)
            {
                if (output.Length > 0)
                    output.Append(" ");

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    output.Append(word[i]);
                }
            }

            Console.WriteLine("Output: " + output.ToString());
        }
    }
}
