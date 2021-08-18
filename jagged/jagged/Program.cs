using System;

namespace jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[4];

            jaggedArray[0] = new int[] { 2, 3, 5, 88, 9 };
            jaggedArray[1] = new int[] { 1, 7, 8 };
            jaggedArray[2] = new int[] { 1, 0, 4, 6 };

            // alternative way

            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 4, 6, 7, 14 },
                new int[] { 1, 2, 3 }
            };

            Console.WriteLine("The Value in the middle of the first entry is {0}", jaggedArray2[0][2]);

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0}", jaggedArray2[i][j]);
                }
            }
            // Create a jagged array, which contains 3 "friends arrays", in which two family members should be stored
            // Introduce family members from different families to each other via console (three introductions)


            string[] joesFamily = new string[] { "Martha", "Robert" };


            string[][] friendsAndFamily = new string[][]
            {
                new string[]{"Michael", "Sandy"},
                new string[]{"Frank", "Claudia"},
                new string[]{"Andrew", "Michelle"},
                joesFamily
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[3][1], friendsAndFamily[2][1]);
            Console.ReadKey();
        }
    }
}
