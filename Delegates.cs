using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of names
            List<string> names = new List<string>() { "Marcus", "Shuree", "Shaniya", "Marquise", "Charmaine" };

            Console.WriteLine("----before----");
            //print the names before the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //calling RemoveAll and passing our method Filter 
            //RemoveAll expects a delegate (predicate)
            names.RemoveAll(Filter); //we passed a method as a paremeter so we don't include the parenthsis().

            Console.WriteLine("----after----");
            //print the names after the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        //a method called Filter that takes a string
        static bool Filter(string s)
        {
            return s.Contains("i");

        }
    }
}
