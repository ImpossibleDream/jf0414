using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace jf0414
{
    public class FileCount
    {
        public static Dictionary<string, int> countWords(string text)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            string path = "C:\\Users\\admin\\Desktop\\count.txt";
            string[] words = Regex.Split(text, path);
            int sum = 0;
            foreach (string word in words)
            {
                if (counts.ContainsKey(word))
                
                    sum++;
                }
            }
            return sum;
        }
    }
    class fileCount
    {
        static void Main(string[] args)
        {
            
        }
    }
}
