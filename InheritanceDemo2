using System;

namespace InheritanceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Marcus Canty", "Marcus", 400000);
            Employee employee2 = new Employee();
            Boss boss = new Boss("Durango", "Marcus Canty", "Marc", 350000);
            Trainees trainees = new Trainees(25, 15, "Marcus Canty", "Marc", 250000);
            employee.Work();
            employee.Pause();
            employee2.Work();
            employee2.Pause();
            boss.Lead();
            trainees.Learn();
            trainees.Work();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    class Employee
    {
        //properties
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        //constructor
        public Employee()
        {
            Name = "Marcus J. Canty";
            FirstName = "Marc";
            Salary = 500000;
        }
        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        //methods
        public virtual void Work()
        {
            Console.WriteLine($"I work hard so I make ${this.Salary} per year.");
        }

        public void Pause()
        {
            Console.WriteLine($"At work my name is {this.Name} but my friends call me {this.FirstName}.");
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        //constructor
        public Boss(string companyCar, string name, string firstName, int salary):base(name, firstName, salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"I'm the leader and that's why I drive a 2022 {this.CompanyCar}.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    class Trainees : Employee
    {
        //properties
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        //constructors
        public Trainees(int workingHours, int schoolHours, string name, string firstName, int salary):base(name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        //methods
        public void Learn()
        {
            Console.WriteLine($"I spent {this.SchoolHours} hours in training this week");
        }

        public override void Work()
        {
            Console.WriteLine($"I only worked {this.WorkingHours} hours this week");
        }
    }
}
