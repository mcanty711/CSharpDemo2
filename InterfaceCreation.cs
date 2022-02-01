using System;

namespace InterfaceCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair kitcheChair = new Chair("Red", "Wood");

            //creating a new object of type car
            Car damagedCar = new Car(80f, "Blue");

            //add the two chairs to the IDestoyable list of the car
            //so that when we destroy the car the destroyable objects
            //that are near the car will get destroyed as well
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(kitcheChair);

            //destroy car
            damagedCar.Destroy();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCreation
{
    interface IDestroyable 
    {
        //property to store the audio file of the destruction sound
        string DestructionSound { get; set; }

        //method to destroy an object
        void Destroy();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCreation
{
    class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        //default constructor
        public Vehicle()
        {
            Speed = 150f;
            Color = "Red";
        }
        //constructor
        public Vehicle(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCreation
{
    //subclass Car which extends Vehicle class
    class Car : Vehicle, IDestroyable
    {
        //implementing the IDestoyable interface's property
        public string DestructionSound { get; set; }

        //creating a new property to store the destroyable object nearby
        //when a car get destroyed it should also destroy the nearby object
        //this list is of type IDestroyable which means it can store any object
        //that implements this interface and we can only access the properties and
        //methods in this interface
        public List<IDestroyable> DestroyablesNearby;

        //simple constructor
        public Car(float speed, string color):base(speed, color)
        {
            //initialize the interface's property with a value in the constructor
            DestructionSound = "CarExplosionSound.mp3";
            //initialize the list of destroyable objects
            DestroyablesNearby = new List<IDestroyable>();
        }
        
        //implementing the interface's method
        public void Destroy()
        {
            //when car gets destroyed the destruction should should play and create an explosion
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create explosion!");

            //go thru each destroyable object nearby and call its Destroy method
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCreation
{
    class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        //default constructor
        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }
        //constructor
        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCreation
{
    //subclass chair that extends Furniture
    class Chair : Furniture, IDestroyable
    {
        //implementing the interface's property
        public string DestructionSound { get; set; }

        //constructor
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            //initializing the interface's property with a value in the constructor
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            //when a chair gets destroyed we should play the destruction sound
            //and spawn the destroyed chair parts
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
