namespace _18.EmailsInTheText
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        // Write a program for extracting all email addresses from given text. 
        // All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

        static void Main(string[] args)
        {
            string str = "Static void Main() nakov@telerik.com. using System,nakov@gmail.com return ,s@w.r.";

            foreach (var email in Regex.Matches(str, @"\w{2,}@\w{6,}\.\w{2,}"))
                Console.WriteLine(email);

            //I assume identifier is not less than 6 characters, host is not less than one character and domain is not less than two characters like a normal e-mail
            string input = "Please contact us by phone (+359 222 222 222) or by email at exa_mple@abv.bg. or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

            string[] separatedInput = input.Split(' ');

            // remove '.' at the end of words => exa_mple@abv.bg. => exa_mple@abv.bg
            for (int i = 0; i < separatedInput.Length; i++)
            {
                string currentWord = separatedInput[i];

                if (currentWord[currentWord.Length - 1] == '.')
                    separatedInput[i] = currentWord.Remove(currentWord.Length - 1);
            }

            for (int i = 0; i < separatedInput.Length; i++) // john.doe@abv.bg    length = 15
            {
                string word = separatedInput[i];

                if (HasAllowedChars(word)) // true
                {
                    int indexOfAt = word.IndexOf("@"); // indexAt = 8

                    if (indexOfAt > 5) // true
                    {
                        int indexOfDot = word.IndexOf(".", indexOfAt + 1); // separatedInput[i].IndexOf(".", 9);  indexDot = 12

                        if (indexOfDot != -1)
                        {
                            if ((word.Substring(indexOfDot, word.Length - indexOfDot - 1)).Length > 1)
                            {
                                Console.WriteLine(word);
                            }
                        }
                    }
                }
            }
        }

        static bool HasAllowedChars(string input)
        {
            bool isWordCharacter = true;

            string availableChars = "0123456789qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM@.-_";

            for (int i = 0; i < input.Length; i++)
            {
                int index = availableChars.IndexOf(input[i]);

                if (index < 0)
                {
                    isWordCharacter = false;
                    break;
                }
            }

            return isWordCharacter;
        }
    }
}
