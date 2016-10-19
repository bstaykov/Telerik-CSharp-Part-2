namespace _11.PrintNumberAsDecHecPercScf
{
    using System;

    class Program
    {
        // 11. Write a program that reads a number and prints it as a decimal number, hexadecimal number,
        // percentage and in scientific notation. Format the output aligned right in 15 symbols.

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", number); // Decimal

            Console.WriteLine("{0,15:X}", number); // Hexadecimal

            Console.WriteLine("{0,15:P2}", number); // Percentage

            Console.WriteLine("{0,15:E}", number); // Scientific notation
        }
    }
}
