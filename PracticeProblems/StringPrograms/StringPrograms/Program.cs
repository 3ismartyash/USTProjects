using System.Text;

internal class Program
{
    static void Main()
    {
        string input = "sri sai yaswanth";

        string[] words = input.Split(' ');
        Array.Reverse(words);

        StringBuilder output = new StringBuilder();
        foreach (string word in words)
        {
            if (output.Length > 0)
                output.Append(" ");
            output.Append(word);
        }

        Console.WriteLine(output);

    }
}
