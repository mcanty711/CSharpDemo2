using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable_IEnumerator
{
    class Program
    {
        // 1. IEnumerable <T> for generic collection
        // 2. IEnumerable for non generic collection


        /// <summary>
        /// IEnumerable<T> contains a single method that you must implement when implementing this interface;
        /// GetEnumerator(), which returns an IEnumerator<T> object.
        /// The returned IEnumerator<T> provides the ability to iterate through the collection
        /// by exposing a current propety that points at teh object we are currently at in the collection.
        /// </summary>
        
        
        /// when it is recommended to use the IEnumerable interface:
        /// Your collection represents a massive database table,
        /// you don't want to copy the entire thing into memory and cause performance issues in your applicaion.
        /// When it is not recommended to use the IEnumerable interface:
        /// You need to results right away and are possibley mutating / editing the objects later on.
        /// In this case its better to use an array or a list


        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }


    }
    class Dog
    {
        //the name of the dog
        public string Name { get; set; }
        //is this a naughty dog
        public bool IsNaughtyDog { get; set; }
        //simple constructor
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }
        //this method prints how many treats the dog recieved
        public void GiveTreat(int numberofTreats)
        {
            //print a message containing the number of treats and the name of the dog
            Console.WriteLine("{0} the dog barked {1} times.", Name, numberofTreats);
        }
    }

    class DogShelter : IEnumerable<Dog>
    {
        //list of type List<Dog>
        public List<Dog> dogs;
        //this constructor will initialize the dogs list with some values
        public DogShelter()
        {
            //initialize the dogs list using the collection-initializer
            dogs = new List<Dog>()
            {
                new Dog("Lucky", true),
                new Dog("Spot", true),
                new Dog("Fido", false),
                new Dog("Lady", false)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
