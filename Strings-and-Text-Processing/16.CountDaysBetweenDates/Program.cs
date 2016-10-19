namespace _16.CountDaysBetweenDates
{
    using System;

    class Program
    {
        // 16. Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:

        // Enter the first date: 27.02.2006
        // Enter the second date: 3.03.2004
        // Distance: 4 days


        static void Main(string[] args)
        {
            DateTime firstDate = new DateTime(2006, 2, 27);

            DateTime secondDate = new DateTime(2004, 3, 3);

            Console.WriteLine("Days between dates : " + Math.Abs((secondDate - firstDate).Days));
        }
    }
}
