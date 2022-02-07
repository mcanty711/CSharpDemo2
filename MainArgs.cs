using System;

namespace MainArgs // this application should be run from the command prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide arguments next time. Enter 'Help' for more details.");
                return;
            }
            if(args[0] == "help")
            {
                Console.WriteLine("For addition, enter 'add' followed by two numbers.");
                Console.WriteLine("For subtraction, enter 'minus' followed by two numbers.");
                return;
            }
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please enter 'help' for details.");
                return;
            }
            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please enter 'help' for details");
                return;
            }

            float result;
            switch (args[0])
            {
                case "add":
                    result = num1 + num2;
                    Console.WriteLine("The sum of {0} and {1} is {2}",  num1, num2, result);
                    break;
                case "sub":
                    result = num1 - num2;
                    Console.WriteLine("The difference of {0} and {1} is {2}", num1, num2, result);
                    break;
                default:
                    Console.WriteLine("Invalid arguments, please enter 'help' for details.");
                    break;
            }

            //Console.WriteLine("Hello World! " + args[0] + " " + args[1]);
        }
    }
}
