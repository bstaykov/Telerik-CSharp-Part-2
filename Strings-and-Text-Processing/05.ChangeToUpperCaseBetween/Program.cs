namespace _05.ChangeToUpperCaseBetween
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        // 5. You are given a text. Write a program that changes the text in all regions surrounded
        // by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested.


        static void Main(string[] args)
        {
            string text = "We are<upcase>a</upcase><upcase></upcase><upcase>a</upcase><upcase></upcase><upcase>a</upcase><upcase></upcase><upcase>a</upcase><upcase></upcase> living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else. We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else. We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.<upcase>a</upcase><upcase> </upcase><upcase>a </upcase><upcase></upcase><upcase>a</upcase><upcase></upcase><upcase>a</upcase> <upcase> </upcase>";
            string copy = text;

            int openTagIndex = 0;
            int closeTagIndex = 0;
            int openTagLength = "<upcase>".Length;
            int closeTagLength = "</upcase>".Length;

            while (openTagIndex != -1 && closeTagIndex != -1)
            {
                openTagIndex = text.IndexOf("<upcase>", openTagIndex);

                if (openTagIndex != -1)
                {
                    closeTagIndex = text.IndexOf("</upcase>", closeTagIndex);

                    if (closeTagIndex != -1)
                    {

                        string substitude = text.Substring(openTagIndex + 8, closeTagIndex - openTagIndex - openTagLength).ToUpper();
                        text = text.Remove(openTagIndex, closeTagIndex - openTagIndex + closeTagLength);
                        text = text.Insert(openTagIndex, substitude);
                    }
                }
            }
            Console.WriteLine(text);

            Console.WriteLine(Regex.Replace(copy, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
        }
    }
}
