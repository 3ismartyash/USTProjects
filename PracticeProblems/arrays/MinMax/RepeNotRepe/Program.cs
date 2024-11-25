//{ 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 } output 1 : 9,4   output 2: 7,8,1,2
namespace RepeNotRepe
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };
            int n = arr.Length;
            List<int> nonrep = new List<int>();
            List<int> rep = new List<int>();

            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }
            foreach (var entry in frequencyMap)
            {
                if (entry.Value > 1)  // Number appears more than once
                {
                    rep.Add(entry.Key);
                }
                else  // Number appears exactly once
                {
                    nonrep.Add(entry.Key);
                }
            }
            Console.Write("non-rep: " + '[' +string.Join(", ",nonrep)+']');
            Console.WriteLine();
            Console.Write("rep: "+'['+string.Join(", ",rep)+']');
        }
    }
}
