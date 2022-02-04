using System;
using System.IO; 

namespace WriteIntoTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Method 1
            string[] hiScore = { "Marcus 1234", "Marquise 1576" };
            File.WriteAllLines(@"C:\Users\mcanty\Documents\Marcus Canty\C#Masterclass\ReadFromTextFiles\hiScore.txt", hiScore);

            //Method 2
            Console.WriteLine("Please give the file a name:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file:");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\mcanty\Documents\Marcus Canty\C#Masterclass\ReadFromTextFiles\" + fileName + ".txt", input);

            //Method 3
            using (StreamWriter file = new StreamWriter(@"C:\Users\mcanty\Documents\Marcus Canty\C#Masterclass\ReadFromTextFiles\myText.txt"))
            {
                foreach (string score in hiScore)
                {
                    if (score.Contains("Marquise"))
                    {
                        file.WriteLine(score);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"C:\Users\mcanty\Documents\Marcus Canty\C#Masterclass\ReadFromTextFiles\myText.txt", true))
            {
                file.WriteLine("Additional line");
            }
        }
    }
}
