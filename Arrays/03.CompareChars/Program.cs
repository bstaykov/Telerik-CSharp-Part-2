namespace _03.CompareChars
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that compares two char arrays lexicographically (letter by letter).

            char[] firstCharArray = {'a', 'b', 'c', 'd', 'e' };
            char[] secondCharArray = { 'b', 'b', 'C', 'd', 'x', 'k' };
            bool areEqual = true;

            if(firstCharArray.Length != secondCharArray.Length)
            {
                Console.WriteLine("The arrays have different length.");
            }

            int len = firstCharArray.Length < secondCharArray.Length ? firstCharArray.Length : secondCharArray.Length;

            for (int i = 0; i < len; i++)
            {
                    Console.WriteLine("Chars[{0}] are equal: {1}", i, firstCharArray[i] == secondCharArray[i]);
                    if (firstCharArray[i] != secondCharArray[i])
                    {
                        areEqual = false;
                    }
            }

            Console.WriteLine("Char arrays are equal: " + areEqual);
        }
    }
}
