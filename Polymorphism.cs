using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car(700, "red");
            //car.ShowDetails();
            //car.Repair();

            //BMW bmw = new BMW("7-Series", 800, "silver");
            //bmw.ShowDetails();
            //bmw.Repair();

            //Audi audi = new Audi("A8", 825, "black");
            //audi.ShowDetails();
            //audi.Repair();

            var cars = new List<Car>
            {
                new BMW("M5", 625, "silver"),
                new Audi("A8", 600, "black")
            };
            foreach (var car in cars)
            {
                car.Repair();
            }

            M5 myM5 = new M5("M5", 400, "silver");
            myM5.Repair();

            //"has a" relationship example
            myM5.SetCarIDInfo(18, "Canty Motors");
            myM5.GetCareIDInfo();
        }
    }
    // you can also seal a class just like a method
    class Car
    {
        //class
        public int HP { get; set; }
        public string Color { get; set; }

        //"has a" relationship
        protected CarInfo carInfo = new CarInfo();
        public void SetCarIDInfo(int idNum, string owner)
        {
            carInfo.IDNum = idNum;
            carInfo.Owner = owner;
        }

        public void GetCareIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carInfo.IDNum, carInfo.Owner);
        }

        //default constructor
        //public Car()
        //{

        //}

        //simple constructor
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;            
        }
        //ShowDetails method()
        public virtual void ShowDetails()
        {
            Console.WriteLine($"MY 2022 Ford GTX has {HP} hp and is {Color}.");
        }
        //Polymorphism allows base class methods to be overriden by derived class methods by using the virtual and override keywords.
        //Repair method()
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
    //BMW Class
    class BMW : Car
    {
        private string brand = "BMW";

        //property
        public string Model { get; set; }

        //default constructor
        //public BMW()
        //{

        //}
        
        //simple constructor
        public BMW(string model, int hp, string color) : base(hp, color)
        {
            this.Model = model;
        }

        //ShowDetails method()
        public sealed override void ShowDetails()
        {
            Console.WriteLine($"MY 2022 {brand} {Model} has {HP} hp and is {Color}.");
        }
        //Polymorphism allows the base class method to be overriden by the derived class method by using the virtual and override keywords.
        //Sealed override method cannot be overriden by a derived method
        //Repair method()
        public sealed override void Repair()
        {
            Console.WriteLine($"Your {brand} {Model} was repaired");
        }
    }
    class Audi : Car
    {
        private string brand = "A8";
        
        //property
        public string Model { get; set; }

        //simple constructor
        public Audi(string model, int hp, string color) : base(hp, color)
        {
            this.Model = model;
        }

        //ShowDetails method()
        public override void ShowDetails()
        {
            Console.WriteLine($"MY 2022 {brand} has {HP} hp and is {Color}.");
        }
        //Repair method()
        
        //Polymorphism allows the base class method to hide the derived class method by using the new keyword.
        public new void Repair()
        {
            Console.WriteLine($"Your {brand} was repaired");
        }

        //public override void Repair()
        //{
        //    Console.WriteLine($"Your {brand} was repaired");
        //}
    }

    class M5 : BMW
    {
        public M5(string model, int hp, string color) : base(model, hp, color)
        {
            this.Model = model;
        }

        public  new void Repair()
        {
            Console.WriteLine("M5 is a fast car");
        }
    }

    //normal inheritance has a "is a" relaionship but there's also a "has a" relationship
    // that has a general information set for 
    class CarInfo
    {
        public int IDNum { get; set; } = 0;
        public string Owner { get; set; } = "Exotic Car Dealer";
    }
}
