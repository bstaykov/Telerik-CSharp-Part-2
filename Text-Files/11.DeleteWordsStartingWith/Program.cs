namespace _11.DeleteWordsStartingWith
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class Program
    {
        // 11. Write a program that deletes from a text file all words that start with the prefix "test".
        // Words contain only the symbols 0...9, a...z, A…Z, _.

        static void Main(string[] args)
        {
            string fileLocation = "../../text.txt";
            string tempfile = "../../output.txt";

            using (StreamReader input = new StreamReader(fileLocation))
            {
                using (StreamWriter output = new StreamWriter(tempfile))
                {
                    string line;

                    while ((line = input.ReadLine()) != null)
                    {
                        output.WriteLine(Regex.Replace(Regex.Replace(line, @"\btest((\d|\w|_)*)(\b)", string.Empty), @"(\s){2,}", " "));
                    }
                }
            }

            using (StreamReader input = new StreamReader(tempfile))
            {
                using (StreamWriter output = new StreamWriter(fileLocation))
                {
                    string line;
                    while ((line = input.ReadLine()) != null)
                    {
                        output.WriteLine(line);
                    }
                }
            }

        }
    }
}
