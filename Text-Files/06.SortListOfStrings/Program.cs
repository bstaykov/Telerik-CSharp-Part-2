namespace _06.SortListOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        // 06. Write a program that reads a text file containing a list of strings,
        // sorts them and saves them to another text file. Example:
        // Ivan			George
        // Peter		Ivan
        // Maria		Maria
        // George		Peter

        private static string[] ReadStringsFromFolder(string directory)
        {
            List<string> listOfStrings = new List<string>();

            using (StreamReader streamReader = new StreamReader(directory))
            {
                string input = streamReader.ReadToEnd();
                string[] separatedInput = input.Split(new[] { " ", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                return separatedInput;
            }
        }

        private static void SaveArrayToDirectory(string directory, string[] array)
        {
            using (StreamWriter streamWriter = new StreamWriter(directory))
            {
                foreach (var item in array)
                {
                    streamWriter.WriteLine(item);
                }
            }
        }

        
        static void Main(string[] args)
        {
            string readDirectory = @"..\..\list.txt";
            string writeDirectory = @"..\..\sortedList.txt";

            string[] arrayOfStrings = ReadStringsFromFolder(readDirectory);

            Array.Sort(arrayOfStrings, StringComparer.InvariantCulture);
            
            SaveArrayToDirectory(writeDirectory, arrayOfStrings);
                        
            Console.WriteLine("Check 'sortedList.txt'");
        }
    }
}
