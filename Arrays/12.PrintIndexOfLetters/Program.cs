namespace _12.PrintIndexOfLetters
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that creates an array containing all letters from the alphabet (A-Z). 
            // Read a word from the console and print the index of each of its letters in the array.

            char[] letters = new char[52];

            // capital letters
            for (int i = 0; i < 26; i++)
            {
                letters[i] = (char)(i + 65);
            }

            // small letters
            for (int i = 26; i < 52; i++)
            {
                letters[i] = (char)(i + 71);
            }

            Console.WriteLine(string.Join(", ", letters));

            Console.Write("Insert a word: ");
            string inputString = Console.ReadLine();

            Console.WriteLine("Letter\t| Index");
            Console.WriteLine(new string('=', 20));
            for (int i = 0; i < inputString.Length; i++)
            {
                char letter = inputString[i];


                for (int j = 0; j < 52; j++)
                {
                    if (letter == letters[j])
                    {
                        Console.WriteLine(letter + "\t| " + j);
                        break;
                    }
                }
            }
            Console.WriteLine(new string('=', 20));

        }
    }
}
