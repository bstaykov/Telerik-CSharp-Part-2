namespace _21.PrintLettersCountInString
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        // 21. Write a program that reads a string from the console and prints all different letters in the string 
        //     along with information how many times each letter is found. 

        static void Main(string[] args)
        {
            string input = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";

            Console.WriteLine("Using array (letters only):");

            int[] values = new int['z' - 'a' + 1];

            foreach (char letter in input.ToLower())
            {
                if ('a' <= letter && letter <= 'z')
                {
                    values[letter - 'a']++;
                }
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != 0)
                {
                    Console.WriteLine("{0}: {1}", (char)(i + 'a'), values[i]);
                }
            }

            Console.WriteLine("Using dictionary:");
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]) == false)
                {
                    dict.Add(input[i], 0);
                }
                dict[input[i]] += 1;
            }

            foreach (var symbol in dict)
            {
                Console.WriteLine("{0}: {1}", symbol.Key, symbol.Value);
            }
        }
    }
}
