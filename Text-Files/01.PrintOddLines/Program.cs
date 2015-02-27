namespace _01.PrintOddLines
{
    using System;
    using System.IO;

    class Program
    {
        // 01. Write a program that reads a text file and prints on the console its odd lines.

        static void Main(string[] args)
        {
            string fileDirectory = @"..\..\test.txt";

            using (StreamReader streamReader = new StreamReader(fileDirectory))
            {
                string fileContent = streamReader.ReadLine();

                while (fileContent != null)
                {
                    Console.WriteLine(fileContent);
                    fileContent = streamReader.ReadLine();
                    fileContent = streamReader.ReadLine();
                }
            }

            //try
            //{
            //    StreamReader streamReader = new StreamReader(fileDirectory);

            //    try
            //    {
            //        string fileContent = streamReader.ReadLine();

            //        while (fileContent != null)
            //        {
            //            Console.WriteLine(fileContent);
            //            fileContent = streamReader.ReadLine();
            //            fileContent = streamReader.ReadLine();
            //        }
            //    }

            //    catch (IOException ex)
            //    {
            //        Console.WriteLine("Error reading file: " + ex.Message);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }
            //    finally
            //    {
            //        streamReader.Close();
            //    }
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("File does not exists: " + ex.Message);
            //}
            //catch (DirectoryNotFoundException ex)
            //{
            //    Console.WriteLine("Invalid path: " + ex.Message);
            //}
        }
    }
}
