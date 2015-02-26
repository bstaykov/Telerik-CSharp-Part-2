namespace _10.ConvertstringToUnicodeCharactersLiterals
{
    using System;
    using System.Text;

    class Program
    {
        // Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

        // Sample input: "Hi!".
        // Expected output: "\u0048\u0069\u0021".

        static string ConvertToUnicode(string text)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char symbol in text)
            {
                sb.AppendFormat("\\u{0:X4}", (int)symbol);
                //sb.AppendFormat("\\u" + ((int)symbol).ToString("X").PadLeft(4, '0'));
            }

            return sb.ToString();
        }

        static void Main()
        {
            Console.WriteLine(ConvertToUnicode("Hi! What is your name!"));
        }

    }
}
