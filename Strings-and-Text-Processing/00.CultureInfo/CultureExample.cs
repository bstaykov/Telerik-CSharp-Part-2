namespace TryThisOut
{
    using System;
    using System.Globalization;

    class CultureExample
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("bg-BG");
            double price = 23.4;
            Console.WriteLine(price.ToString("C", culture));
        }
    }
}
