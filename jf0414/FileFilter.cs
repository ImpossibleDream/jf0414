using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace jf0414
{
    class FileFilter
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\admin\\Desktop\\filter.txt";
            string path1 = "C:\\Users\\admin\\Desktop\\ffilter.txt";
            FilterLinesWithNoNumbers(path, path1);
            Console.ReadKey();
        }

        void FilterLinesWithNoNumbers(string filePath, string destinationFilePath)
        {
           
        }
    }
    }
}
