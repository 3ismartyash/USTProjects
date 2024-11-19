using System.Net;
using System.Text;

namespace day2
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebRequest req = WebRequest.Create("http://www.google.com");
            WebResponse resp = req.GetResponse();

            StreamReader reader = new StreamReader(resp.GetResponseStream(), Encoding.ASCII);

            Console.WriteLine(reader.ReadToEnd());
        }
    }
}