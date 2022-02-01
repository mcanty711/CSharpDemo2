using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);

            bool ticketComparision = t1.Equals(t2);
            Console.WriteLine(ticketComparision);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Ticket : IEquatable<Ticket>
    {
        //property to store the duration of the ticket in hours
        public int DurationInHours { get; set; }
        //constructor
        public Ticket(int durationInHours)
        {
            this.DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
