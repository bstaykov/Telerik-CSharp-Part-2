using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.DeleteWordsStartingWith
{
    class Program
    {
        // 11. Write a program that deletes from a text file all words that start with the prefix "test".
        // Words contain only the symbols 0...9, a...z, A…Z, _.

        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader(@"../../text.txt"))
            {
                using (StreamWriter output = new StreamWriter(@"../../output.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; )
                    {
                        output.WriteLine(Regex.Replace(Regex.Replace(line, @"\btest((\d|\w|_)*)(\b)", ""), @"(\s){2,}", " "));
                    }
                }
            }

            File.Replace(@"../../output.txt", @"../../text.txt", @"..\..\backup.txt");

        }
    }
}
