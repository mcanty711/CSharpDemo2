using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);

            Console.Write("enter new grade for index 0: ");
            string input = (Console.ReadLine());
            // assign value to array
            grades[0] = int.Parse(input);
            Console.WriteLine("Grades at index 0 : {0}", grades[0]);

            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);

            int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
                counter++;
            }

            string[] bestFriends = new string[5] { "Abraham", "Eliajah", "Jeremiah", "John the Baptist", "Jesus" };
            foreach (string bestFriend in bestFriends)
            {
                Console.WriteLine("My best friends are: {0}", bestFriend);
            }


            Boolean valid = false;
            string inputValueType = String.Empty;
            Console.Write("Enter 1st input: ");
            string inputValue = Console.ReadLine();
            Console.Write("Enter the datatype: Press 1 for string, Press 2 for integer,  Press 3 for Boolean: ");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;

                case 2:
                    int retValue;
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool retFlag = false;
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    Console.WriteLine("Not able to detect the input type. Something went wrong");
                    break;
            }
            Console.WriteLine("You entered a value: {0}", inputValue);
            if (valid)
            {
                Console.WriteLine("It is valid: {0}", inputValueType);
            }
            else
            {
                Console.WriteLine("It is an invalid : {0}", inputValueType);
            }

            // declare a 2D array
            string[,] matrix;

            // 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3 }, //row 0
                {4,5,6 }, //row 1
                {7,8,9 }  //row 2
            };
            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.WriteLine("14 equals 2 * ? = {0}", array2D[2, 0]);

            string[,,] array3D = new string[,,]
            {
                {
                    { "zero", "one"},
                    { "ten", "eleven" }
                },
                {
                    { "hundred", "thousand"},
                    { "million", "billion" }
                }
            };

            Console.WriteLine("The spelling of number 11 is: {0}", array3D[0, 1, 1]);

            string[,] array2DString = new string[3, 2] //another way to make a multi-deminsional array
            {
                {"fish", "shrimp" },
                {"hamburger", "sausage" },
                {"steak", "liver" }
            };
            array2DString[2, 1] = "chicken";

            Console.WriteLine("Liver is very healthy but I'd rather eat {0}", array2DString[2, 1]);

            int deminsions = array2DString.Rank;
            Console.WriteLine("To figure out the deminsions of an array use the Rank property - array2DString has: {0}", deminsions);

            static bool IsAllAlphabetic(string value)
            {
                foreach (char c in value)
                {
                    if (!char.IsLetter(c))
                        return false;
                }
                return true;
            }
        }

    }
}
