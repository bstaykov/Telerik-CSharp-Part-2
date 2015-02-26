using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SortListOfStrings
{
    class Program
    {
        // 06. Write a program that reads a text file containing a list of strings,
        // sorts them and saves them to another text file. Example:
        // Ivan			George
        // Peter		Ivan
        // Maria		Maria
        // George		Peter


        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\list.txt");
            List<string> list = new List<string>();

            string line = reader.ReadLine();
            int count = 0;

            while (line != null)
            {
                list.Add(line);
                count++;
                line = reader.ReadLine();
            }

            list.Sort();

            StreamWriter writer = new StreamWriter(@"..\..\sortedList.txt", false);

            for (int i = 0; i < count; i++)
            {
                writer.WriteLine(list[i]);
            }

            reader.Close();
            writer.Flush();
            writer.Close();

            Console.WriteLine("Check 'sortedList.txt'");
        }
    }
}
