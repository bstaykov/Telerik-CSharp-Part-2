namespace _22.ListDifferentWordPlusCount
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        // Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

        static void Main(string[] args)
        {
            string text = "i will try to explain, what is dictionary and how to use dictionary. I will! Will I?!";
            text = text.ToLower();
            string[] allWordsArr = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> rechnik = new Dictionary<string, int>();

            foreach (var word in allWordsArr)
            {
                if (rechnik.ContainsKey(word))
                {
                    rechnik[word] = rechnik[word] + 1;
                }
                else
                {
                    rechnik.Add(word, 1);
                }
            }

            foreach (var word in rechnik)
            {
                Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
            }



            ////string str = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";

            ////var dict = new Dictionary<string, int>();

            ////foreach (Match word in Regex.Matches(str, @"\w+"))
            ////{
            ////    dict[word.Value] = dict.ContainsKey(word.Value) ? dict[word.Value] + 1 : 1;
            ////}

            ////foreach (var pair in dict)
            ////{
            ////    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            ////}
        }
    }
}
