namespace _20.ExtractPalindromeWords
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        // 20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;

            return true;
        }

        static void Main()
        {
            string str = "Static void Main() ABBA, using System lamal, exe.";

            //foreach (Match item in Regex.Matches(str, @"\w+"))
            //{
            //    if (IsPalindrome(item.Value))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            char[] separators = new char[] { ' ', ',', '.' };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    Console.WriteLine(word);
                }
            }

            //foreach (Match item in Regex.Matches(str, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b"))
            //    Console.WriteLine(item);
        }
    }
}
