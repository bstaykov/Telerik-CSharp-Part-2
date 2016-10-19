namespace _03.LineNumbers
{
    using System;
    using System.IO;

    class Program
    {
        // Write a program that reads a text file and inserts line numbers in front of each of its lines. 
        // The result should be written to another text file.

        static void Main(string[] args)
        {
            string fileToReadFrom = @"..\..\ReadFile.txt";
            string fileToWriteIn = @"..\..\FinalFile.txt";

            using (StreamWriter streamWriter = new StreamWriter(fileToWriteIn, false))
            {
                using (StreamReader reader = new StreamReader(fileToReadFrom))
                {
                    string line = reader.ReadLine();
                    int lineCount = 1;

                    while (line != null)
                    {
                        streamWriter.WriteLine(lineCount + " " + line);
                        line = reader.ReadLine();
                        lineCount++;
                    }
                }
            }

            Console.WriteLine("Done! Check file 'FinalFile.txt'!");
        }
    }
}
