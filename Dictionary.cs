using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                    new Employee("CEO", "Gwyn", 65, 200),
                    new Employee("Manager", "Joe", 35, 25),
                    new Employee("HR", "Lora", 32, 21),
                    new Employee("Secretary", "Peter", 28, 18),
                    new Employee("Developer", "Archie", 55, 35),
                    new Employee("Intern", "Ernest", 22, 8),
            };

            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeeDirectory.Add(emp.Role, emp);
            }

            for (int i = 0; i < employeeDirectory.Count; i++)
            {
                //using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> KeyValuePair = employeeDirectory.ElementAt(i);
                //pring the key
                Console.WriteLine("Key: {0}, i is {1}", KeyValuePair.Key, i);
                //storing the value in an employee object
                Employee employeeValue = KeyValuePair.Value;
                //printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary {0},", employeeValue.Salary);

            }

            string key = "CEO";
            if (employeeDirectory.ContainsKey(key))
            {
            Employee empl = employeeDirectory[key];
            Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this key");
            }

            Employee result = null;
            //using TryGetValue() - it returns true if the operator was successful and false otherwise
            if (employeeDirectory.TryGetValue("Intern", out result));
            Console.WriteLine("Employee Name: {0}, Role: {1}, Age: {2} Salary: {3}", result.Name, result.Role, result.Age, result.Salary);

        }
    }
    class Employee
    {
        //Properties
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        //constructor
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
