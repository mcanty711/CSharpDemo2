using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.WriteSomething();

            WriteSomthingSpecific("I am an argument and am called from a method");

            Console.WriteLine(Add(14, 15));

            Console.WriteLine(Multiply(5, 9));

            Console.WriteLine(Divide(84, 13));

            string friend1 = "Tracy";
            string friend2 = "Sherry";
            string friend3 = "Allen";
            GreetFriends(friend1);
            GreetFriends(friend2);
            GreetFriends(friend3);

            GreetFriends2(friend1, friend2, friend3);

            Console.WriteLine("Please enter an integer: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second integer: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input1 + input2);

            Console.WriteLine(Calculate());

            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();


            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format exception, please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was null");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }

            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", ++num);
        }

        public void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomthingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }

        public static int Multiply(int multiplier1, int multiplier2)
        {
            return multiplier1 * multiplier2;
        }

        public static double Divide(double dividend, double divisor)
        {
            return dividend / divisor;
        }

       
        public static void GreetFriends(string friendName)
        {
            Console.WriteLine("Hi {0} ", friendName + ", my friend!");
        }

        public static void GreetFriends2(string friendName1, string friendName2, string friendName3)
        {
            Console.WriteLine("Hi " + friendName1 + ", my friend!");
            Console.WriteLine("Hi " + friendName2 + ", my friend!");
            Console.WriteLine("Hi " + friendName3 + ", my friend!");
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number: ");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number: ");
            string number2Input = Console.ReadLine();
            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);
            int result = num1 + num2;
            
            return result; 
        }
    }
}
