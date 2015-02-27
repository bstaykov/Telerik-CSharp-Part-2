namespace _09.DeleteOddLinesFromFile
{
    using System;
    using System.IO;

    class Program
    {
        // 09. Write a program that deletes from given text file all odd lines. The result should be in the same file.

        static void Main(string[] args)
        {
            string testFileLocation = @"..\..\test.txt";
            string tempFileLocation = @"..\..\temp.txt";
            string backupFileLocation = @"..\..\backup.txt";

            using (StreamReader reader = new StreamReader(testFileLocation))
            {
                using (StreamWriter writer = new StreamWriter(tempFileLocation))
                {
                    string line = reader.ReadLine();
                    int count = 1;

                    while (line != null)
                    {
                        if (count % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }

                        line = reader.ReadLine();
                        count++;
                    }

                    //reader.Close();
                    //writer.Flush();
                    //writer.Close();

                    File.Replace(tempFileLocation, testFileLocation, backupFileLocation);
                }
                
            }            
        }
    }
}
