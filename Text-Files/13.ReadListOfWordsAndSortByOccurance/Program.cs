﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.ReadListOfWordsAndSortByOccurance
{
    class Program
    {
        // 13. Write a program that reads a list of words from a file words.txt 
        // and finds how many times each of the words is contained in another file test.txt.
        // The result should be written in the file result.txt and the words should be sorted by the
        // number of their occurrences in descending order. Handle all possible exceptions in your methods.

        static void Main(string[] args)
        {
            try
            {
                string[] words = File.ReadAllLines("../../words.txt");
                int[] values = new int[words.Length];

                // Count words
                using (StreamReader input = new StreamReader("../../test.txt"))
                    for (string line; (line = input.ReadLine()) != null; )
                        for (int i = 0; i < words.Length; i++)
                            values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;

                // Sort
                Array.Sort(values, words);

                // Write output
                using (StreamWriter output = new StreamWriter("../../result.txt"))
                    for (int i = words.Length - 1; i >= 0; i--) // Descending order
                        output.WriteLine("{0}: {1}", words[i], values[i]);
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
    }
}