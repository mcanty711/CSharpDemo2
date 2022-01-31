using System;

namespace InheritanceVirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Lucky", 10);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.Play();
            dog.Eat();
            dog.MakeSound();
        }
    }
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            //in our case all our animals are hungry by default
            this.IsHungry = true;
        }
        //an empty virtual method MakeSound for other classes to override that inherit from Animal
        public virtual void MakeSound()
        {

        }
        //a virtual method called Eat which sub classes can override
        public virtual void Eat()
        {
            //check if animal is hungry
            if (IsHungry)
            {
                //if yes then print the name of the animal +"is eating"
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                //otherwise print that the animal is not hungry
                Console.WriteLine($"{ Name} is not hungry");
            }
        }
        //virtual method Play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
    class Dog : Animal
    {
        //bool property to check if the dog is happy
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            //all dogs are happy
            IsHappy = true;
        }

        //override the virtual Eat method
        public override void Eat()
        {
            //to call the eat method from our base class we use the base keyword
            base.Eat();
        }
        //override of the virtual method MakeSound
        public override void MakeSound()
        {
            //since every animal will make a totally different sound,
            //each animal will implement their own version of MakeSound
            Console.WriteLine("Bark");
        }

        //override of the virtual method Play
        public override void Play()
        {
            //check if the dog is happy if so call the Play method from the base class
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
