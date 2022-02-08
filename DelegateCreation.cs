using System;
using System.Collections.Generic;

namespace DelegateCreation //create our own delegate to filter through a list of people
{
    class Program
    {
        //defining a delegate type called FilterDelegate that takes a 
        //person object and returns a bool
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            //Create 4 Person objects
            Person p1 = new Person() { Name = "Marcus", Age = 50};
            Person p2 = new Person() { Name = "Suzan", Age = 41 };
            Person p3 = new Person() { Name = "Patricia", Age = 28 };
            Person p4 = new Person() { Name = "Michael", Age = 11 };
            Person p5 = new Person() { Name = "Bret", Age = 69 };

            //add the objects to a List named people
            List<Person> people = new List<Person> { p1, p2, p3, p4, p5 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adult", people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);

            FilterDelegate filter = delegate (Person p) //Anonymous method
            {
                return p.Age >= 20 && p.Age <= 30;
            };//don't forget the ; at the end because we're declaring a variable
              //and assigning its value at the same time just like int x = 3; for example

            DisplayPeople("Between 20 and 30:", people, filter);

            //we can pass an anonymous method as the third parameter
            DisplayPeople("All: ", people, delegate (Person p) { return true; });


        }

        //a method to display the list of people that passes the filter condition
        //(returns true)
        //this method will take a title to be displayed, the list of people, and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            //print title
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                //check if this person passes the filter
                if (filter(p))
                {
                    //print the person's name and age
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
        }

        //Filters
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }

    class Person
    {
        //name property
        public string Name { get; set; }
        //age property
        public int Age { get; set; }
    }
}
