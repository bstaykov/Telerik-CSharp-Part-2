using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.ReplaceWords
{
    class Program
    {
        // 08. Modify the solution of the previous problem to replace only whole words (not substrings).

        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader("../../text.txt"))
            {
                using (StreamWriter output = new StreamWriter("../../output.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; )
                    {
                        output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    }
                }
            }
        }
    }
}
