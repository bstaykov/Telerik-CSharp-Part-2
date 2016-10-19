namespace _00.DateCultureExample
{
    using System;
    using System.Globalization;
    using System.Threading;

    class DateTimeCultureParser
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            
            Console.WriteLine("Formater");
            Console.WriteLine("{0:d.M.yyyy EXTRA h:mm:ss}", now);
            Console.WriteLine();

            Console.WriteLine("ParseExact");
            string input = "19.02.2015 13:32:03";
            DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(date);
            Console.WriteLine();

            Console.WriteLine("Default");
            Console.WriteLine(now);
            Console.WriteLine();

            Console.WriteLine("InvariantCulture");
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine(now);
            Console.WriteLine();
        }
    }
}
