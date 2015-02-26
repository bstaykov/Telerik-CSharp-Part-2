using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReplaceSubstring
{
    class Program
    {
        // 07. Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
        // Ensure it will work with large files (e.g. 100 MB).

        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader("../../text.txt"))
            {
                using (StreamWriter output = new StreamWriter("../../output.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; )
                    {
                        string replace = line.Replace("start", "finish");
                        output.WriteLine(replace);
                    }
                }
            }
        }
    }
}
