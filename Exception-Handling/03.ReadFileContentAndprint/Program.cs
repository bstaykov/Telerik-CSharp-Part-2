namespace _03.ReadFileContentAndprint
{
    using System;
    using System.IO;

    class Program
    {
        // Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
        // reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
        // Be sure to catch all possible exceptions and print user-friendly error messages.


        static void Main()
        {
            try
            {
                //string path = Environment.CurrentDirectory + "\\HelloFile.txt";
                string path = @"..\..\HelloFile.txt";
                Console.WriteLine(File.ReadAllText(path));
                //Console.WriteLine("File directory: " + Environment.CurrentDirectory);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught!\n{0}\n\n{1}", e.GetType().Name, e.Message);
            }
        }
    }
}
