namespace _06.BinaryToHex
{
    using System;

    class Program
    {
        // 06. Write a program to convert binary numbers to hexadecimal numbers (directly).


        static string BinToHex(string input)
        {
            string hex = string.Empty;
            int remainder = input.Length % 4;

            if (remainder != 0)
            {
                input = input.PadLeft(input.Length + (4 - remainder), '0');
            }
            for (int i = 0; i < input.Length; i += 4)
            {
                string fourByFour = input.Substring(i, 4);
                hex += string.Format("{0:X}", Convert.ToByte(fourByFour, 2));
            }
            return hex;
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Insert binary number. 0 & 1 only!");
                string input = Console.ReadLine();
                string hex = BinToHex(input);
                Console.WriteLine(hex);
            }
        }
    }
}
