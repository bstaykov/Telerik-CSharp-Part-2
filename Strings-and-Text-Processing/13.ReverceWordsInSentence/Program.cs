namespace _13.ReverceWordsInSentence
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        // 13 Write a program that reverses the words in given sentence. Example:

        // C# is not C++, not PHP and not Delphi!
        // Delphi not and PHP, not C++ not is C#!

        static void Main(string[] args)
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";

            Console.WriteLine(ReverceSentence(sentence));

            //string regex = @"\s+|,\s*|\.\s*|!\s*"; 
            //List<string> words = new List<string>(); // Stack
            //List<string> separators = new List<string>(); // Queue

            //foreach (string word in Regex.Split(sentence, regex))
            //    words.Add(word);

            //foreach (Match separator in Regex.Matches(sentence, regex))
            //    separators.Add(separator.Value);

            //for (int i = 0; i < separators.Count; i++)
            //    Console.Write(words[words.Count - 2 - i] + separators[i]); // Without the last empty word

            //Console.WriteLine();
            
        }

        private static string ReverceSentence(string sentence) 
        {
            char[] wordsSeparators = new char[] { ' ', '.', ',', '!', '?' };
            char[] marks = new char[] { '.', ',', '!', '?' };

            StringBuilder sb = new StringBuilder(sentence.Length);

            string[] words = sentence.Split(wordsSeparators, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, char> separatorsIndices = FindSeparatorsPossitions(sentence, marks, wordsSeparators);

            int index = sentence.IndexOfAny(wordsSeparators);
            int counter = 0;
            for (int i = words.Length -1 ; i >= 0; i--)
            {
                counter++;
                if (separatorsIndices.ContainsKey(counter))
                {
                    sb.Append(words[i] + separatorsIndices[counter] + " ");
                }
                else
                {
                    sb.Append(words[i] + " "); 
                }
            }

            string result = sb.ToString().TrimEnd();

            return result;
        }

        private static Dictionary<int, char> FindSeparatorsPossitions(string sentence, char[] marks, char[] wordsSeparators)
        {
            var separatorsPossitions = new Dictionary<int, char>();

            int indexOfMark = 0;

            while (indexOfMark != -1)
            {
                indexOfMark = sentence.IndexOfAny(marks, indexOfMark);
                if (indexOfMark != -1)
                {
                    string substring = sentence.Substring(0, indexOfMark);
                    int countOfWordsToThisMark = substring.Split(wordsSeparators, StringSplitOptions.RemoveEmptyEntries).Length;
                    separatorsPossitions.Add(countOfWordsToThisMark, sentence[indexOfMark]);
                    indexOfMark++;
                }
            }

            return separatorsPossitions;
        }
    }
}
