using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEyes;

            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }

            Console.WriteLine("Will the next card be red, white or black?");
            string response = Console.ReadLine();
            Random card = new Random();
            int numCard;

            numCard = card.Next(1, 4);
            if (numCard == 1)
            {
                Console.WriteLine("The next card will be red.");
            }
            else if (numCard == 2)
            {
                Console.WriteLine("The next card will be the white.");
            }
            else
            {
                Console.WriteLine("The next card will be black.");
            }
        }
    }
}
