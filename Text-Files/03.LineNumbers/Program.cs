using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LineNumbers
{
    class Program
    {
        // Write a program that reads a text file and inserts line numbers in front of each of its lines. 
        // The result should be written to another text file.

        static void Main(string[] args)
        {
            string fileToReadFrom = @"..\..\ReadFile.txt";
            StreamReader reader = new StreamReader(fileToReadFrom);
            string line = reader.ReadLine();

            string fileToWriteIn = @"..\..\FinalFile.txt";
            StreamWriter writer = new StreamWriter(fileToWriteIn, false);
            int lineCount = 1;

            while (line != null)
            {
                writer.WriteLine(lineCount + " " + line);
                line = reader.ReadLine();
                lineCount++;
            }

            reader.Close();
            writer.Flush();
            writer.Close();

            Console.WriteLine("Done! Check file 'FinalFile.txt'!");
        }
    }
}
