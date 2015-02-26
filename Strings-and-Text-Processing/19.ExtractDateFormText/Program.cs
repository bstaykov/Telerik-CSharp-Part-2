namespace _19.ExtractDateFormText
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Program
    {
        // 19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
        // Display them in the standard date format for Canada.


        static void Main(string[] args)
        {
            ////string str = "Static void Main() 12.10.2012, 50.13.2012";

            ////DateTime date;

            ////MatchCollection colection = Regex.Matches(str, @"\b\d{2}.\d{2}.\d{4}\b");

            ////foreach (Match item in colection)
            ////{
            ////    if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            ////    {
            ////        Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            ////        //Console.WriteLine(date);
            ////    }
            ////}

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string text = @"срок: 23:59 31.01.2013. 
                                Видео - 22.01.2013. 
                                Видео - 23 януари 2013 тралала
                                Видео - 31.02.2013 - да ама не!
                                Видео - 23.01.2013 - Наков.
                                Краен срок: 23:59 часа на 03.02.2013.";
            string[] words = text.Split(new char[] { ' ', '?', '!', ';', ',', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            CultureInfo culture = new CultureInfo("en-ca");

            foreach (var word in words)
            {
                string wordNoDot = word;
                if (wordNoDot[wordNoDot.Length - 1].Equals('.'))
                {
                    wordNoDot = wordNoDot.Substring(0, wordNoDot.Length - 1);
                }

                if (wordNoDot[0] == '.')
                {
                    wordNoDot = wordNoDot.Substring(1);
                }

                try
                {
                    DateTime date = DateTime.ParseExact(wordNoDot, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine("Invariant culture: " + date);
                    string dateCanada = date.ToString("dd/MM/yy", culture);
                    Console.WriteLine("Canada: " + dateCanada);
                }
                catch (Exception)
                {
                    Console.WriteLine(".");
                }
            }

        }
    }
}
