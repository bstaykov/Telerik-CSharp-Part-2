namespace _05.CountWorkingDays
{
    using System;

    class Program
    {
        // Write a method that calculates the number of workdays between today and given date, passed as parameter. 
        // Consider that workdays are all days from Monday to Friday except a fixed list of public 
        // holidays specified preliminary as array.

        private static void CountWorkingDays(DateTime endDate, DateTime[] holidays)
        {
            int count = 0;

            for (DateTime date = DateTime.Now; date < endDate; date = date.AddDays(1))
            {
                bool isWeekDay = date.DayOfWeek.ToString() != "Saturday" && date.DayOfWeek.ToString() != "Sunday";

                if (isWeekDay)
                {
                    bool isHoliday = false;
                    for (int i = 0; i < holidays.Length; i++)
                    {
                        if (holidays[i].Month == date.Month && holidays[i].Day == date.Day)
                        {
                            isHoliday = true;
                        }
                    }
                    if (isHoliday == false)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("From " + DateTime.Now + " to " + endDate + " there are " + count + " working days!");

        }

        static void Main(string[] args)
        {
            DateTime[] holidays = { 
                                      new DateTime(1, 3, 3), // year = 1 because it doesnt matter :)
                                      new DateTime(1, 5, 24), 
                                      new DateTime(1, 1, 1), 
                                      new DateTime(1, 5, 6),
                                      new DateTime(1, 5, 1),
                                      new DateTime(1, 12, 24) 
                                  };

            CountWorkingDays(new DateTime(2016, 12, 31), holidays);
        }
    }
}
