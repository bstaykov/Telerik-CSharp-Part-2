namespace _07.ReplaceSubstring
{
    using System;
    using System.IO;

    class Program
    {
        // 07. Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
        // Ensure it will work with large files (e.g. 100 MB).

        static void Main(string[] args)
        {
            string fileLocation = "../../text.txt";
            string outputFile = "../../output.txt";

            using (StreamReader input = new StreamReader(fileLocation))
            {
                using (StreamWriter output = new StreamWriter(outputFile))
                {
                    string line;
                    while ((line = input.ReadLine()) != null)
                    {
                        string replace = line.Replace("start", "finish");
                        output.WriteLine(replace);
                    }
                }
            }

            using (StreamReader input = new StreamReader(outputFile))
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
