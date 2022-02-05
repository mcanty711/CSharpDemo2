using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            int num2 = 7;
            double num3 = 8.4;
            double num4 = 10.7;
            int num5 = -21;

            Console.WriteLine($"Math ceiling of {num3} is: {Math.Ceiling(num3)}");
            Console.WriteLine($"Math floor of {num4} is: {Math.Floor(num4)}");
            Console.WriteLine($"Lower of {num1} and {num2} is: {Math.Min(num1, num2)}" );
            Console.WriteLine($"Higher of {num1} and {num2} is: {Math.Max(num1, num2)}");
            Console.WriteLine("{0} to the power of 3 is: {1}", num1, Math.Pow(num1,3));
            Console.WriteLine("Pi is: " + Math.PI);
            Console.WriteLine("The square root of {0} is: {1}", num1, Math.Sqrt(num1));
            Console.WriteLine("The absolute value of |{0}| is: {1}", num5, Math.Abs(num5));
            Console.WriteLine("The Sin of 1 is: " + Math.Sin(1));
        }
    }
}
