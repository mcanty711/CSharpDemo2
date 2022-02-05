using System;

namespace Enums
{
    enum Weeks
    {
        Mon, Tue, Wed, Thr, Fri, Sat, Sun
    }
    enum Months
    {
        Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Weeks.Mon);
            Console.WriteLine((int)Weeks.Mon); //cast it to it's index number
            Console.WriteLine((int)Months.Jan); //shows that you don't have to start the emun at index zero - see Jan in line 11
        }
    }
}
