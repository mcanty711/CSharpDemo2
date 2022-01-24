using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Marcus = new Human("Marcus", "Canty", "brown", 50);
            Marcus.IntroduceMyself();

            Human Shuree = new Human("Shuree", "Allen", "brown");
            Shuree.IntroduceMyself();

            Human Marquise = new Human("Marquise", "Allen", 11);
            Marquise.IntroduceMyself();

            Human Charmaine = new Human("Charmaine", "Allen");
            Charmaine.IntroduceMyself();

            Human Shaniya = new Human("Shaniya");
            Shaniya.IntroduceMyself();

            
            Box box = new Box(10, 20, 5);
            // no longer need to set the value of the Box because we created a constructor which now requires arguments.
            //box.Length= 10;
            //box.Height = 20;
            //box.Width = 5;
            box.Width = 50; // you can still override the constructor by setting the value.
            //box.Volume = box.Length * box.Width * box.Height;
            //box.FrontSurface = box.Length * box.Height;

            box.DisplayInfo();

            Members members = new Members();
            members.Introducing(true);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }
        // parameterized constructor
        public Human(string firstName)
        {
            this.firstName = firstName;
        }
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age; 
        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }    
        // member method
        public void IntroduceMyself()
        {
            if (age != 0 && eyeColor != null)
            {
                Console.WriteLine("Hi, my name is {0} {1}, I'm {2} and I have {3} eyes.", firstName, lastName, age, eyeColor);
            }
            if (eyeColor == null && age != 0)
            {
                Console.WriteLine("Hi, my name is {0} {1} and I'm {2} years old.", firstName, lastName, age);
            }
            if(eyeColor != null && age == 0)
            {
                Console.WriteLine("Hi, my name is {0} {1}, I have {2} eyes.", firstName, lastName, eyeColor);
            }
            if(age == 0 && eyeColor == null && lastName!= null)
            {
                Console.WriteLine("Hi, my name is {0} {1}.", firstName, lastName);
            }
            else if(age == 0 && eyeColor == null && lastName == null)
            {
                Console.WriteLine("Hi, my name is {0}.", firstName);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Box
    {
        private int _length;
        private int _height;
        private int _width;
        //private int _volume;
        //private int _frontSurface;

        public int Length
        {
            set
            {
                if (value <= 0)
                {
                    _length = value;
                }
                else
                {
                    this._length = value;
                }             
            }
            get
            {
                return this._length;
            }
        }

        public int Height
        {
            get
            {
                return this._height;
            }
            set
            {
                if (value <= 0)
                {
                    _height = value;
                }
                else
                {
                this._height = value;
                }
            }
        }

        public int Width
        {
            get
            {
                return this._width;
            }
            set
            {
                if (value <= 0)
                {
                    _width = value;
                }
                else
                {
                    this._width = value; 
                }
            }
        }

        public int Volume 
        {
            get
            {
                return this._length * _width * _height;
            }
        }
        public int FrontSurface 
        {
            get
            {
                return this._length * _height; 
            }
        }

        //constructor
        public Box(int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("The box length is {0}, height is {1} and width is {2}", Length, Height, Width);
            Console.WriteLine("The box volume is {0} && box front surface is {1}", Volume, FrontSurface);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Members
    {
        //member - private fields
        private string _memberName;
        private string _jobTitle;
        private int _salary = 20000;

        //member - public fields
        public int _age;

        //member - Property which safely exposes jobTitle and is starts with cap letter.
        public string JobTitle 
        {
            get
            {
                return _jobTitle;
            }

            set 
            {
                this._jobTitle = value; 
            } 
        }

        //public member Methods which can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0} && my job title is {1}, I'm {2} years old ", _memberName, _jobTitle, _age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", _salary);
        }

        //member - constructor
        public Members()
        {
            _age = 30;
            _memberName = "Marcus";
            _salary = 100000;
            _jobTitle = "developer";
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor 
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Destruction of Members object");
        }
    }
}
