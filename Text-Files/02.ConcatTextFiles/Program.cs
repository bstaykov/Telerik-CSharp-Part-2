namespace _02.ConcatTextFiles
{
    using System;
    using System.IO;
    using System.Text;

    class Program
    {
        // 02. Write a program that concatenates two text files into another text file.

        static void Main(string[] args)
        {
            string firstFileDirectory = @"..\..\File1.txt";
            string secondFileDirectory = @"..\..\File2.txt";
            string fileToWrite = @"..\..\FinalFile.txt";

            using (StreamWriter streamWriter = new StreamWriter(fileToWrite, false, Encoding.GetEncoding("UTF-8")))
            {
                using (StreamReader streamReader = new StreamReader(firstFileDirectory))
                {
                    string firstFileContent = streamReader.ReadToEnd();
                    streamWriter.WriteLine(firstFileContent);
                }

                using (StreamReader secondStreamReader = new StreamReader(secondFileDirectory))
                {
                    string secondFileContent = secondStreamReader.ReadToEnd();
                    streamWriter.WriteLine(secondFileContent);
                }
            }

            Console.WriteLine("DONE! Check 'FinalFile.txt'");
        }
    }
}
