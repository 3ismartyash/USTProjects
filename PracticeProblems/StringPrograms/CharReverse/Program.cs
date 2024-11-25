using System.Text;
namespace CharReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "sri sai yaswanth";
            string[] words = input.Split();

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

           Console.WriteLine(output);
        }
    }
}
