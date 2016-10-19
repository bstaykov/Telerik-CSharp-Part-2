namespace _03.CheckExprexionsBrackets
{
    using System;

    class Program
    {
        // 3. Write a program to check if in a given expression the brackets are put correctly.
        // Example of correct expression: ((a+b)/5-d).
        // Example of incorrect expression: )(a+b)).


        static void Main(string[] args)
        {
            Console.WriteLine("Write an expression: ");
            string input = Console.ReadLine();

            int bracketsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (bracketsCount < 0)
                {
                    break;
                }
                if (input[i].Equals('(') )
                {
                    bracketsCount++;
                }
                if (input[i].Equals(')'))
                {
                    bracketsCount--;
                }
            }

            if (bracketsCount != 0)
            {
                Console.WriteLine("Incorrect brackets!!!");
            }
            else
            {
                Console.WriteLine("Brackets are correct!!!");
            }

        }
    }
}
