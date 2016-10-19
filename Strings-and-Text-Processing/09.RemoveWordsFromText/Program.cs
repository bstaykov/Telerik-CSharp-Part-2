namespace _09.RemoveWordsFromText
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        // We are given a string containing a list of forbidden words and a text containing some of these words.
        // Write a program that replaces the forbidden words with asterisks. Example:

        // Microsoft announced its next generation PHP compiler today.
        // It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

        //Words: "PHP, CLR, Microsoft"
        //The expected result:

        // ********* announced its next generation *** compiler today. 
        // It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbidenwords = { "PHP", "CLR", "Microsoft" };

            foreach (var item in forbidenwords)
            {
                text = text.Replace(item, new String('*', item.Length));
            }

            Console.WriteLine(text);
            
            //string message = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            //string words = "PHP, CLR, Microsoft";

            //Console.WriteLine(Regex.Replace(message, words.Replace(", ", "|"), m => new String('*', m.Length)));

        }
    }
}
