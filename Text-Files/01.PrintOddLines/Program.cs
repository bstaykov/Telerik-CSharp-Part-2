using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintOddLines
{
    class Program
    {
        // 01. Write a program that reads a text file and prints on the console its odd lines.

        static void Main(string[] args)
        {
            string addressLocation = @"..\..\test.txt";
            StreamReader reader = new StreamReader(addressLocation);

            string fileContent = reader.ReadLine();

            while (fileContent != null)
            {
                Console.WriteLine(fileContent);
                fileContent = reader.ReadLine();
                fileContent = reader.ReadLine();
            }
            reader.Close();
        }
    }
}
