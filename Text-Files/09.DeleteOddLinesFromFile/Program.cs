using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DeleteOddLinesFromFile
{
    class Program
    {
        // 09. Write a program that deletes from given text file all odd lines. The result should be in the same file.

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\test.txt");
            string line = reader.ReadLine();
            int count = 1;

            StreamWriter writer = new StreamWriter(@"..\..\temp.txt");

            while (line != null)
            {
                if (count % 2 == 0)
                {
                    writer.WriteLine(line);
                }
                line = reader.ReadLine();
                count++;
            }
            
            reader.Close();
            writer.Flush();
            writer.Close();

            File.Replace(@"..\..\temp.txt", @"..\..\test.txt", @"..\..\backup.txt");
        }
    }
}
