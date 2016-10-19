namespace _24.SortListOfWords
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        // 24. Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

        static void Main(string[] args)
        {
            string list = "Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order ";

            string[] arr = list.Split(' ');

            Array.Sort(arr);
            //Array.Reverse(arr);

            Console.WriteLine(string.Join(" ", arr));


            //string str = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";

            //var words = new List<string>();

            //foreach (Match word in Regex.Matches(str, @"\w+"))
            //{
            //    words.Add(word.Value);
            //}

            //words.Sort();

            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }
}
