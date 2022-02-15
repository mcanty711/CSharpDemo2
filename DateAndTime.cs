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
        }
        static  DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
