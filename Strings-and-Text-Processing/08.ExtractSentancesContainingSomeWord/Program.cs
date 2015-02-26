namespace _08.ExtractSentancesContainingSomeWord
{
    using System;
    using System.Text;

    class Program
    {
        /*Write a program that extracts from a given text all sentences containing given word.
        Example:

        The word is: in

        The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

        The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

        Consider that the sentences are separated by . and the words – by non-letter symbols.*/

        static void Main(string[] args)
        {
            string text = "In we live.We in.We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. in ..in.in.five days. in ";
            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("Insert word : ");
            string word = Console.ReadLine();
            string wordSeparatedBySpaces = " " + word + " ";
            Console.WriteLine();

            int openIndex = 0;
            int closeIndex = 0;

            StringBuilder builder = new StringBuilder();

            while (openIndex != -1 && closeIndex != -1 && openIndex < text.Length - 1)
            {
                closeIndex = text.IndexOf('.', openIndex + 1);

                if (closeIndex != -1)
                {
                    int inIndex = text.IndexOf(wordSeparatedBySpaces, openIndex, closeIndex - openIndex);

                    if (inIndex != -1)
                    {
                        builder.Append(text.Substring(openIndex, closeIndex - openIndex + 1));
                    }

                    openIndex = closeIndex + 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(builder);
        }
    }
}
