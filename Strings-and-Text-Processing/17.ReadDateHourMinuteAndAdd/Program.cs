namespace _17.ReadDateHourMinuteAndAdd
{
    using System;
    using System.Globalization;

    class Program
    {
        // 17. Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
        // and prints the date and time after 6 hours and 30 minutes (in the same format) 
        // along with the day of week in Bulgarian.

        static void Main(string[] args)
        {
            Console.WriteLine("Insert date in the format (dd.MM.yyyy HH:mm:ss):");
            string input = Console.ReadLine();

            DateTime parsedDate = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            //DateTime parsedDate = DateTime.ParseExact("19.02.2015 13:32:03", "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(parsedDate);

            parsedDate = parsedDate.AddHours(6);
            parsedDate = parsedDate.AddMinutes(30);
            
            Console.WriteLine(parsedDate);

            Console.WriteLine("{0} {1}",  parsedDate.ToString("dddd", new CultureInfo("bg-BG")), parsedDate);
            Console.WriteLine(parsedDate.ToString("d"));
            Console.WriteLine(parsedDate.ToString("dd"));
            Console.WriteLine(parsedDate.ToString("dddd"));
            Console.WriteLine(parsedDate.ToString("m"));
            Console.WriteLine(parsedDate.ToString("MM"));
            Console.WriteLine(parsedDate.ToString("y"));
            Console.WriteLine(parsedDate.ToString("yy"));
            Console.WriteLine(parsedDate.ToString("yyyy"));
            Console.WriteLine(parsedDate.ToString("dddd", new CultureInfo("bg-BG")));
        }
    }
}
