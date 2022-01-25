using System;

namespace NestedForLoops_2DArrays
{
    class Program
    {
        static int[,] matrix =
        {
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
        };
        static void Main(string[] args)
        {
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
                //item = 2;  (this cannot be done with a foreach loop but it can with a nested for loop)
            }

            Console.WriteLine("\nThis is our 2D array printed using nested for loop");
            // nested for loop
            // outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++) // this goes thru each row
            {
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++) // this goes thru each column
                {
                    // matrix[i, j] = 0; (now we can assign it a value.
                    Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine("\nThis is going to print only the even number in the matrix");
            for (int i = 0; i < matrix.GetLength(0); i++) // this goes thru each row
            {
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++) // this goes thru each column
                {
                    // matrix[i, j] = 0; (now we can assign it a value.
                    if (matrix[i, j] % 2 == 0) // this prints the even numbers in the matrix
                    {
                        Console.Write(matrix[i, j] + " ");
                    }

                }
            }
            Console.WriteLine("\nThis is going to print the matrix diagonal from top left to bottom right");
            for (int i = 0; i < matrix.GetLength(0); i++) // this goes thru each row
            {
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++) // this goes thru each column
                {
                    // matrix[i, j] = 0; (now we can assign it a value.
                    if (i == j) // this prints the matrix diagonally                   
                        Console.Write(matrix[i, j] + " ");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine(""); // this adds astetics 
            }
            // to replace the diagonal values with assigned values
            for (int i = 0; i < matrix.GetLength(0); i++) // this goes thru each row
            {
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++) // this goes thru each column
                {
                    // matrix[i, j] = 0; (now we can assign it a value.
                    if (i == j) // this prints the matrix diagonally                   
                        matrix[i, j] = 1;
                    else
                        Console.Write(" ");
                }
                Console.WriteLine(""); // this adds astetics 
                foreach (int item in matrix)
                {
                    Console.Write(item + " ");
                }
            }
            // you can do the same thing with just on for loop.
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, i]);
            }
            // backwards diagonal
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                Console.WriteLine(matrix[i,j]);
            }

        }
    }
}
