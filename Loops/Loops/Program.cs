using System;

namespace Loops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int counter = 0; counter < 50; counter += 5)
            {
                Console.WriteLine(counter + " is lower than 50");
            }
            Console.WriteLine("For loop is done");
            int lengthOfText = 0;
            var wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend: ");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough! " + wholeText);

        }
    }
}
