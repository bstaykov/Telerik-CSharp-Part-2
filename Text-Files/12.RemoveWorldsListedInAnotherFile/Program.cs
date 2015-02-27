namespace _12.RemoveWorldsListedInAnotherFile
{
    using System;
    using System.IO;
    using System.Security;
    using System.Text.RegularExpressions;

    class Program
    {
        // 12. Write a program that removes from a text file all words listed in given another text file. 
        // Handle all possible exceptions in your methods.


        static void Main(string[] args)
        {
            try
            {
                string regex = @"\b(" + string.Join("|", File.ReadAllLines("../../words.txt")) + @")\b";

                Console.WriteLine(regex);

                using (StreamReader input = new StreamReader("../../input.txt"))
                {
                    using (StreamWriter output = new StreamWriter("../../output.txt"))
                    {
                        string line;

                        while ((line = input.ReadLine()) != null)
                        {
                            output.WriteLine(Regex.Replace(line, regex, string.Empty));
                        }
                    }
                }
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //private static void Main()
        //{
        //    try
        //    {
        //        var words = File.ReadAllLines("words12.txt", Encoding.Default);
        //        using (var reader = new StreamReader("text12.txt", Encoding.Default))
        //        using (var writer = new StreamWriter("text12Out.txt"))
        //            while (!reader.EndOfStream)
        //            {
        //                var line = new StringBuilder(reader.ReadLine());
        //                var buffer = new StringBuilder();
        //                for (int i = 0; i < line.Length; i++)
        //                {
        //                    var ch = line[i];
        //                    if (!char.IsLetter(ch))
        //                    {
        //                        if (words.Contains(buffer.ToString()))
        //                        {
        //                            line.Remove(i - buffer.Length, buffer.Length);
        //                            i -= buffer.Length;
        //                        }
        //                        buffer.Clear();
        //                    }
        //                    else
        //                    {
        //                        buffer.Append(ch);
        //                    }
        //                }
        //                writer.WriteLine(line.ToString());
        //            }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("{0}:{1}", e.GetType().Name, e.Message);
        //    }
        //}
    }
}
