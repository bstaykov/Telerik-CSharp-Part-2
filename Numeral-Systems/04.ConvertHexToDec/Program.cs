namespace _04.ConvertHexToDec
{
    using System;

    class Program
    {
        // 04. Write a program to convert hexadecimal numbers to their decimal representation.

        static int GetNumber(char hexSymbol)
        {
            if (hexSymbol >= 'A')
            {
                return (hexSymbol - 'A') + 10;
            }
            else
            {
                return hexSymbol - '0';
            }
        }

        static int Base16ToBase10(string input)
        {
            int result = 0;

            for (int i = input.Length - 1, powerOfSixteen = 1; i >= 0; i--, powerOfSixteen *= 16)
            {
                result += GetNumber(input[i]) * powerOfSixteen;
            }

            return result;
        }

        static void Main()
        {
            while(true){
                bool check = true;
                string input = Console.ReadLine().ToUpper();

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'A' || input[i] == 'B' || input[i] == 'C' || input[i] == 'D' || input[i] == 'E' || input[i] == 'F' || input[i] == '1' || input[i] == '2' || input[i] == '3' || input[i] == '4' || input[i] == '5' || input[i] == '6' || input[i] == '7' || input[i] == '8' || input[i] == '9' || input[i] == '0')
                    {
                        // ok
                    }
                    else
                    {
                        check = false;
                    }

                }

                if (check)
                {
                    Console.WriteLine(Base16ToBase10(input));
                }
                else
                {
                    Console.WriteLine("Incorect input!");
                }
            }
        }
    }
}
