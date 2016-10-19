namespace _23.ReplaceConsecutiveLetters
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        // 23. Write a program that reads a string from the console and replaces all series of consecutive 
        // identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

        static void Main(string[] args)
        {
            string text = "AaAaAaaAaAAaAANnnnnnnNNNNnnnnNNNNNNnnAAaaAAAaaAAACCcccCCooOOonnnnndddDDdddaaaaa".ToLower();

            StringBuilder sb = new StringBuilder(text[0].ToString());
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    sb.Append(text[i + 1]);
                }
            }

            Console.WriteLine("New fixed Text : " + sb);

            //sb = new StringBuilder(text);

            //for (int i = 0; i < sb.Length - 1; i++)
            //{
            //    if (sb[i] == sb[i + 1])
            //    {
            //        sb.Remove(i, 1);
            //        i--;
            //    }
            //}
            //Console.WriteLine("New fixed Text : " + sb);


            string str = "aaaabbbbbcdddeeeedssaasasa";

            Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
        }
    }
}
