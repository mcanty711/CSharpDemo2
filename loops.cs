using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter < 20; counter += 2) //prints the odd number up to 20
            {
                Console.WriteLine("Counter: " + counter);
            }

            int doCounter = 15; //do while loops run the code once then checks the condition
            do
            {
                Console.WriteLine(doCounter);
                doCounter++;
            } while (doCounter < 5);

            int lengthOfText = 0;
            string wholeText = String.Empty;
            do
            {
                Console.Write("Please enter the name of friend: ");
                string nameOfFriend = Console.ReadLine();
                int currentLength = nameOfFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfFriend;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks that was enough!" + wholeText);

            int counter1 = 0;
            while (counter1 < 10)
            {
                Console.WriteLine(counter1);
                counter1++;
            }

            int peopleCount = 0;
            string noCount = String.Empty;

            while (noCount.Equals(string.Empty))
            {
                Console.WriteLine("Please press enter to increase the count by 1 or anything else plus enter " +
                    "to finish count");
                noCount = Console.ReadLine();
                peopleCount++;
                Console.WriteLine("Current people count is {0}", peopleCount);
            }
            Console.WriteLine("There are {0} kids are on the bus. Please enter to close the program", peopleCount);

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if (counter == 3)
                {
                    Console.WriteLine("At 3 stop");
                    break;
                }
            }
            for (int counter = 0; counter < 10; counter++)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("Now comes odd number");
                    continue;
                }
                Console.WriteLine(counter);
            }


            string input = "0";
            int count = 0;           
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number input: {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 to calculate score average");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("-------------------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine("Total is: {0}", total);
                    Console.WriteLine("Count is: {0}", count);
                    Console.WriteLine("The average score of your students is {0}", average);
                }
                if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber; // or total = total + currentNumber
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20");
                    }
                    continue;
                }
                count++;
            }
        }
    }
}
