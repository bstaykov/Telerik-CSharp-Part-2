namespace _01.ReadYearFromConsole
{
    using System;

    class Program
    {
        // 01. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 
                && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            }

            return false;
        }
        
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("{0} is leap-year : {1}", date.Year, DateTime.IsLeapYear(date.Year));

            while (true)
            {
                Console.Write("Insert year: ");
                string input = Console.ReadLine();
                int year;
                bool canParseToNumber = int.TryParse(input, out year);

                if (canParseToNumber && 0 < year )
                {
                    Console.WriteLine("IsLeapYear : " + IsLeapYear(year));
                    Console.WriteLine("System.DateTime.IsLeapYear : " + DateTime.IsLeapYear(year));
                    Console.WriteLine();
                }
            }
        }
    }
}
