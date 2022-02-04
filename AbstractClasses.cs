using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new Cube(15);
            cube.GetInfo();

            Sphere sphere = new Sphere(15);
            sphere.GetInfo();

            //create objects of the different classes by creating an array of shapes
            Shape[] shapes = { new Cube(4), new Sphere(3) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}.");

                //Abstract and as and is Keyword / Polymorphism
                Cube iceCube = shape as Cube; 
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is not a cube");
                }
                if(shape is Cube)
                {
                    Console.WriteLine("This shape is a cube");
                }

                //cast from object to a Cube (it only works if object contains a cube)
                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;
                Console.WriteLine("{0} has a volume of {1}", cube2.Name, cube2.Volume());
            }
        }
    }
    //abstract class cannot create an object but we can use its members like properties and methods
    abstract class Shape
    {
        public string Name { get; set; }
        
        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        //abstract method without implementation but whatever class inherits will have to provide implementation
        public abstract double Volume();
    }

    class Cube : Shape
    {
        public double Length { get; set; }

        //constructor
        public Cube(double length)
        {
            Name = "Cube"; //inherited from Shape class
            Length = length;
        }
        //method
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo(); //even though it overrides the base class GetInfo method it calls the GetInfo from base class with the keyword base
            Console.WriteLine($"The Cube has a length of {Length} and a volume of {Volume()}");
        }
    }
    class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double radius)
        {
            Name = "Sphere";
            this.Radius = radius;
        }
        public override double Volume()
        {
            return (Math.Pow(Radius, 3))*Math.PI*(4/3);
        }
        public override void GetInfo()
        {
            base.GetInfo(); //even though it overrides the base class GetInfo method it calls the GetInfo from base class with the keyword base
            Console.WriteLine($"The Sphere has a radius of {Radius} and a volume of {Volume()}");
        }

    }
}
