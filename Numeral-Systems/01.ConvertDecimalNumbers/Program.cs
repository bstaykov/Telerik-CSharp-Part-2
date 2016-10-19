namespace _01.ConvertDecimalNumbers
{
    using System;

    class Program
    {
        // 1. Write a program to convert decimal numbers to their binary representation.

        static int ReadNumber()
        {
            int toBeConverted = 0;
            while (true)
            {
                Console.Write("Insert a number: ");
                string input = Console.ReadLine();
                bool parse = int.TryParse(input, out toBeConverted);
                if (parse)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorect input!");
                }
            }

            return toBeConverted;
        }

        static string ConvertDecimalToBinary(int number)
        {
            string numberAsBinary = string.Empty;
            bool negative = false;

            if (number < 0)
            {
                number += int.MaxValue;
                number++;
                negative = true;
            }

            do
            {
                numberAsBinary = (number & 1) + numberAsBinary;
                number >>= 1;
            }
            while (number > 0);

            if (negative)
            {
                numberAsBinary = numberAsBinary.PadLeft(31, '0');

                numberAsBinary = "1" + numberAsBinary;

                return numberAsBinary;
            }

            return numberAsBinary.PadLeft(32, '0');
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int number = ReadNumber();
                string result = ConvertDecimalToBinary(number);
                Console.WriteLine(result);
                //check
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            }
        }
    }
}
