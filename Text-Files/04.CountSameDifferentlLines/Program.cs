namespace _04.CountSameDifferentlLines
{
    using System;
    using System.IO;

    class Program
    {
        // 04. Write a program that compares two text files line by line and prints the number of lines that are the same 
        // and the number of lines that are different. Assume the files have equal number of lines.

        static void Main(string[] args)
        {
            string firstFile = @"..\..\file1.txt";
            string secondFile = @"..\..\file2.txt";

            using (StreamReader firstStreamReader = new StreamReader(firstFile))
            {
                using (StreamReader secondStreamReader = new StreamReader(secondFile))
                {
                    string firstReaderLine = firstStreamReader.ReadLine();
                    string secondReaderLine = secondStreamReader.ReadLine();
                    int countEqualLines = 0;
                    int countDifferentLines = 0;

                    while (firstReaderLine != null && secondReaderLine != null)
                    {
                        if (firstReaderLine.Equals(secondReaderLine))
                        {
                            countEqualLines++;
                        }
                        else
                        {
                            countDifferentLines++;
                        }

                        firstReaderLine = firstStreamReader.ReadLine();
                        secondReaderLine = secondStreamReader.ReadLine();
                    }

                    Console.WriteLine("Equal lines: " + countEqualLines);
                    Console.WriteLine("Different lines: " + countDifferentLines);
                }
            }
        }
    }
}
