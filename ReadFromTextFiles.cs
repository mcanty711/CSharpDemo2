using System;

namespace ReadFromTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1 - reading text
            string text = System.IO.File.ReadAllText(@"C:\Users\mcanty\Documents\Marcus Canty\C#Masterclass\ReadFromTextFiles\textFile.txt");
            Console.WriteLine("Textfile contains following text: {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\mcanty\Documents\Marcus Canty\C#Masterclass\ReadFromTextFiles\textFile.txt");
            Console.WriteLine("Contents of textFile.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
        }
    }
}
