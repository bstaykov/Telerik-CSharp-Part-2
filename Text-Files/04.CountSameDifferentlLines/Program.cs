using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSameDifferentlLines
{
    class Program
    {
        // 04. Write a program that compares two text files line by line and prints the number of lines that are the same 
        // and the number of lines that are different. Assume the files have equal number of lines.


        static void Main(string[] args)
        {
            string file1 = @"..\..\file1.txt";
            string file2 = @"..\..\file2.txt";

            StreamReader reader1 = new StreamReader(file1);
            StreamReader reader2 = new StreamReader(file2);

            string line1 = reader1.ReadLine();
            string line2 = reader2.ReadLine();
            int countEqualLines = 0;
            int countDifferentLines = 0;

            while (line1 != null && line2 != null)
            {
                if (line1.Equals(line2))
                {
                    countEqualLines++;
                }
                else
                {
                    countDifferentLines++;
                }
                line1 = reader1.ReadLine();
                line2 = reader2.ReadLine();
            }
            
            reader1.Close();
            reader2.Close();

            Console.WriteLine("Equal lines: " + countEqualLines);
            Console.WriteLine("Different lines: " + countDifferentLines);
        }
    }
}
