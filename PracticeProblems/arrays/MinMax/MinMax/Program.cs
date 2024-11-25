namespace MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array: ");
            int arrayLength = int.Parse(Console.ReadLine());

            
            int[] numbers = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Enter element {i + 1} ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);

            Console.WriteLine("The minimum Number is: " + numbers[0]);
            Console.WriteLine("The maximum Number is: " + numbers[arrayLength - 1]);
        }
    }
}
