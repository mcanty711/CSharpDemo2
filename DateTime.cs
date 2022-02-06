using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1971, 09, 27);
  
            Console.WriteLine("My birthday is {0}", dateTime);

            // current date
            Console.WriteLine("Today is: {0}", DateTime.Today);

            // current time
            Console.WriteLine("The date and time is: {0}", DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("I want you to start work tomorrow: {0}", tomorrow);

            DayOfWeek dayOfWeek = DateTime.Today.DayOfWeek;
            Console.WriteLine("Today is {0}", dayOfWeek);

            DateTime firstDayOfYear = GetFirstDayOfYear(2022);
            Console.WriteLine("First day of the year 2022 is: {0}", firstDayOfYear);

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute is: {0}", now.Minute);

            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Day passed since {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
        static  DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
