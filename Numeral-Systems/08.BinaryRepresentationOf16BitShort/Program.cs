namespace _08.BinaryRepresentationOf16BitShort
{
    using System;

    class Program
    {
        // Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

        static string GetBinary(short s)
        {
            string b = String.Empty;

            for (int i = 0; i < 16; i++)
            {
                int mask = s >> i;
                b = (mask & 1) + b;
            }

            return b;
        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Insert 16-bit signed integer number(short) : ");
                string input = Console.ReadLine();
                short parsed = short.Parse(input);
                Console.WriteLine(GetBinary(parsed));
            }
        }


        //// same as exersize 1.0 but with 'short'
        //static short ReadAndParse()
        //{
        //    short toBeConverted = 0;
        //    bool boolean = true;
        //    while (boolean)
        //    {
        //        Console.Write("Insert a number: ");
        //        string input = Console.ReadLine();
        //        bool parse = short.TryParse(input, out toBeConverted);
        //        if (parse)
        //        {
        //            boolean = false;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Incorect input!");
        //        }
        //    }

        //    return toBeConverted;
        //}

        //static void ConvertDecimal()
        //{
        //    short decNumber = ReadAndParse();
        //    short check = decNumber;

        //    string strBinNumber = "";
        //    bool negative = false;

        //    // проверка дали числото е отрицателно
        //    if (decNumber < 0)
        //    {
        //        decNumber += short.MaxValue;
        //        decNumber++;
        //        negative = true;
        //    }

        //    do
        //    {
        //        strBinNumber = (decNumber & 1) + strBinNumber;
        //        decNumber >>= 1;
        //    }
        //    while (decNumber > 0);

        //    if (negative)
        //    {
        //        strBinNumber = strBinNumber.PadLeft(15, '0');

        //        strBinNumber = 1 + strBinNumber;
        //    }
        //    else
        //    {
        //        //strBinNumber = strBinNumber.PadLeft(16, '0');

        //    }

        //    Console.WriteLine(strBinNumber);

        //    //check
        //    Console.WriteLine(Convert.ToString(check, 2));
        //}

        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        ConvertDecimal();
        //    }
        //}
    }
}
