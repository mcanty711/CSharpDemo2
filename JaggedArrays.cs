using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //      index                  0    1    2    3
            // normal array of type int : [15],[21],[23],[13]
            //      index                      0                         1                    2   
            // jagged array of type int : [array1([15],[13],[5])], [array2([7],[8],[2])],[array3([2],[4],[1])]
            
            // declare jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            //alternate way:
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2,3,5,7,11 },
                new int[] {1,2,3}
            };

            Console.WriteLine("The value 5 in middle of first entry is {0}", jaggedArray2[0][2]);
            
            // use a for loop to get every element in the jagged array
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0} ", jaggedArray2[i][j]);
                }
            }

            string[][] friendArrays = new string[3][];
            friendArrays[0] = new string[] { "Marc", "Jay" };
            friendArrays[1] = new string[] { "Melody", "Crystal" };
            friendArrays[2] = new string[] { "Cynthia", "Sheila" };

            Console.WriteLine("Hi {0}, I would like to introduce you to {1}", friendArrays[0][1], friendArrays[1][0]);
        }
    }
}
