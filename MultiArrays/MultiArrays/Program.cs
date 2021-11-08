// Created by Aurimas A. Nausedas on 08/18/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;

namespace MultiArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // declare 2D array
            string[,] matrix;

            // declare 3D array
            string[,,] threeD;

            // 2D array

            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            Console.WriteLine("Central value is {0} while 7th is {1}", array2D[1, 1], array2D[2,0]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001"},
                    {"010","011"},
                    {"Hi there","What's up?"}
                },
                {
                    {"100","101"},
                    {"110","111"},
                    {"Another stuff","How are you?"}
                }
            };

            Console.WriteLine("9th value is {0} while 3th is {1}", array3D[1, 1, 0], array3D[0, 1, 0]);
            Console.WriteLine("11th value is {0} while 6th is {1}", array3D[1, 2, 0], array3D[0, 2, 1]);

            string[,] array2DString = new string[3, 2]
            {
                {"one","two" },
                {"three","four" },
                {"five","six" }
            };

            array2DString[1, 1] = "chicken";
            Console.WriteLine("The value is {0}", array2DString[1, 1]);

            int dims = array2DString.Rank;

            Console.WriteLine("Dimension is {0}", dims);

            int[,] array2D2 = { { 1, 2}, { 3, 4} };

            foreach (int element in array2D)
            {
                Console.WriteLine(element + " ");
            }

            Console.WriteLine("Nested for loop: ");
            // outer loop
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                // inner for loop
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if(array2D[i,j] % 2 == 0)
                    //if(i == j) // diagonal
                        Console.WriteLine(array2D[i,j] + " ");
                    else
                        Console.WriteLine(" ");
                }
            }

            for (int i = 0, j = 2; i < array2D.GetLength(0); i++, j--)
            {
                Console.WriteLine(array2D[i, j]);
            }
        }
    }
}
