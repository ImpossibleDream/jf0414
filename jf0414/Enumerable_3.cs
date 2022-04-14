using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jf0414
{
    class Enumerable_3
    {
        static void Main(string[] args)
        {
            //Select
            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x*x);
            foreach (int num in squares)
            {
                Console.WriteLine(num);
            }

            //Sum
            List<float> numbers = new List<float> { 4.30F, 5.25F, 5.26F, 10.08f, 19.99F };
            float sum = numbers.Sum();
            Console.WriteLine("\nThe sum of the numbers is {0}.\n", sum);

            //Contains
            string[] cities = { "Beijing", "Bangkok", "Tokyo", "London","New York" };
            string city = "Bangkok";
            bool hasOK = cities.Contains(city);
            Console.WriteLine("The array {0} contain '{1}'.\n", hasOK ? "does" : "does not", city);

            //ThenBy   (sort by the legth?)
            string[] zones = { "Sanya", "Weizhoudao", "ChiangMai", "Bangkok", "Phuket" };
            IEnumerable<string> query = zones.OrderBy(zone => zone.Length).ThenBy(zone => zone);
            foreach (string zone in query)
            {
                Console.WriteLine(zone);
            }
        }
    }
}
