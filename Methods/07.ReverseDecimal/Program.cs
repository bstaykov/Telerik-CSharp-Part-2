namespace _07.ReverseDecimal
{
    using System;

    class Program
    {
        // Write a method that reverses the digits of given decimal number. Example: 256  652

        static decimal ReverseDecimal(decimal number)
        {
            string input = number.ToString();
            string reversed = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                reversed = input[i] + reversed;
            }

            number = decimal.Parse(reversed);
            return number;
        }

        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            decimal reverces = ReverseDecimal(number);

            Console.WriteLine(reverces);
        }
    }
}
