namespace _14.UseDictionaryWordsAndExplanations
{
    using System;

    class Program
    {
        // 14. A dictionary is stored as a sequence of text lines containing words and their explanations. 
        // Write a program that enters a word and translates it by using the dictionary. Sample dictionary:

        // .NET – platform for applications from Microsoft
        // CLR – managed execution environment for .NET
        // namespace – hierarchical organization of classes

        static void Main(string[] args)
        {
            string[] arr = { ".NET - platform for applications from Microsoft", 
                               "CLR - managed execution environment for .NET", 
                               "namespace - hierarchical organization of classes" };

            Console.Write("Word : ");
            string input = Console.ReadLine();
            string word = string.Empty;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                index = arr[i].IndexOf('-');
                word = arr[i].Substring(0, index).Trim();

                if (string.Compare(input, word, true) == 0)
                {
                    Console.WriteLine("Explanation: " + arr[i].Substring(index + 1).Trim());
                }
            }
        }
    }
}
