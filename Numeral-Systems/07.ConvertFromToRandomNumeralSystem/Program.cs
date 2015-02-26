namespace _07.ConvertFromToRandomNumeralSystem
{
    using System;

    class Program
    {
        // 07. Write a program to convert from any numeral system of given base s to any other numeral system of base d
        // (2 ≤ s, d ≤  16).

        //works for base = 36 too; up to 'Z';

        static char GetChar(int number)
        {
            if (number >= 10)
            {
                return (char)('A' + number - 10); // 'A' + 11 - 10 = 11; return 'B';
            }
            else
            {
                return (char)('0' + number);
            }
        }

        static int GetNumber(char symbol)
        {
            if (symbol >= 'A')
            {
                return (symbol - 'A') + 10;
            }
            else
            {
                return symbol - '0';
            }
        }

        static string Base10ToBaseX(int number, int baseTo)
        {
            string result = String.Empty;

            while (number != 0)
            {
                int remainder = number % baseTo;
                char symbol = GetChar(remainder);
                result = symbol + result;
                number /= baseTo;
            }

            return result;
        }

        static int BaseXToBase10(string input, int baseFrom)
        {
            int result = 0;

            for (int i = input.Length - 1, power = 1; i >= 0; i--, power *= baseFrom)
            {
                result += GetNumber(input[i]) * power;
            }

            return result;
        }

        static string BaseXToBaseY(string inputString, int baseFrom, int baseTo)
        {
            Console.WriteLine("Base : " + inputString);
            int convertToDec = BaseXToBase10(inputString, baseFrom);
            Console.WriteLine("Decimal : " + convertToDec);

            return Base10ToBaseX(convertToDec, baseTo);
        }

        static void Main()
        {
            Console.WriteLine("Result : " + BaseXToBaseY("1011", 2, 16));
            Console.WriteLine();
            Console.WriteLine("Result : " + BaseXToBaseY("FF", 16, 10));
            Console.WriteLine();
            Console.WriteLine("Result : " + BaseXToBaseY("EE", 15, 3));
        }
    }
}
