using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList is a Non-Generic Collection
            // declaring an ArrayList with undefined amount of objects
            ArrayList myArrayList = new ArrayList();
            // declaring an ArrayList with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(13);

            // delete element with specific value from the arrayList
            myArrayList.Remove(13);
            myArrayList.Remove(13);
            myArrayList.Remove(13);

            // delete element at specified position
            myArrayList.RemoveAt(0);

            Console.WriteLine("Elements in myArrayList: " + myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine("Sum of int and doubles: " + sum);

            // List is a Generic collection - otherwise it's similar to ArrayList
            Console.WriteLine( Solution() );  

        }
        public static List<int> Solution()
        {
            List<int> myList = new List<int>();
            for (int i = 100; i <= 170; i++)
            {
                if (i % 2 == 0)
                {
                    myList.Add(i);
                }

            }
            return myList;
        }
    }
}
