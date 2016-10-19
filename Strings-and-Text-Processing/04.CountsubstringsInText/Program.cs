namespace _04.CountSubstringsInText
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        // Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

        static void Main(string[] args)
        {
            Console.WriteLine("Insert some text: ");
            string text = Console.ReadLine().ToLower();

            Console.WriteLine("Insert a word/substring:");
            string substring = Console.ReadLine().ToLower();
            int count = 0;

            int index = 0;

            while (true)
            {
                index = text.IndexOf(substring, index);

                if (index >= 0)
                {
                    count++;
                    index += substring.Length;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("The result is: " + count);

            Console.WriteLine("Check: " + Regex.Matches(text, substring, RegexOptions.IgnoreCase).Count);
        }
    }
}
