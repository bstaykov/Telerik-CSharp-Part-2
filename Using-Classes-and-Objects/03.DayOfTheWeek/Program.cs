namespace _03.DayOfTheWeek
{
    using System;

    class Program
    {
        // 03. Write a program that prints to the console which day of the week is today. Use System.DateTime.

        private static void DayOfTheWeek()
        {
            // 1
            Console.WriteLine(DateTime.Now.DayOfWeek);
            // 2
            //Console.WriteLine(DateTime.Today.DayOfWeek);
        }

        static void Main(string[] args)
        {
            DayOfTheWeek();
        }
    }
}
