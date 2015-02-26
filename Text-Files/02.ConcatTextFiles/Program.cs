using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConcatTextFiles
{
    class Program
    {
        // 02. Write a program that concatenates two text files into another text file.

        static void Main(string[] args)
        {
            // file 1
            string addressLocation = @"..\..\File1.txt";
            StreamReader reader = new StreamReader(addressLocation);
            string fileContent = reader.ReadToEnd();

            // write file 1
            string fileToWrite = @"..\..\FinalFile.txt";
            StreamWriter writer = new StreamWriter(fileToWrite, false, Encoding.GetEncoding("UTF-8"));
            writer.WriteLine(fileContent);

            // file 2
            addressLocation = @"..\..\File2.txt";
            reader = new StreamReader(addressLocation);
            fileContent = reader.ReadToEnd();

            //write file 2
            writer.WriteLine(fileContent);

            reader.Close();
            writer.Flush();
            writer.Close();

            Console.WriteLine("DONE! Check 'FinalFile.txt'");
        }
    }
}
