// Created by Aurimas A. Nausedas on 08/18/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;

namespace FunctiuonsAndMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var number = 13;
            var number_two = 25;
            string friend1 = "Jonas";
            var friend2 = "Domas";
            var friend3 = "Dainius";
            var sum = Add(number, number_two);
            string input = Console.ReadLine();
            Console.WriteLine(input); // Whatever you input
            WriteSomething(); // Hello! I am called from a method :)
            WriteSomethingSpecific("I am an argument and am called from a method"); // I am an argument and am called from a method
            Console.WriteLine(number); // 13
            Console.WriteLine("num1: " + number + " num2: " + number_two + " The sum is " + sum); // num1: 13 num2: 25 The sum is 38
            Console.WriteLine(Add(5, 11)); // 16
            Console.WriteLine(Multiply(5, 11)); // 55
            Console.WriteLine(Divide(25, 13)); // 1.92307692307692
            Console.WriteLine(Add(Add(1, 2), Add(3, 4))); // 10
            GreetFriend(friend1, friend2, friend3); // Hi Jonas, my friend | Hi Domas, my friend | Hi Dainius, my friend
            // ConsoleWriteLine(GreetFriend(friend1)) is not possible as you cant print the method
            // Console.Read();
            Calculate(); // Please enter first number: 43 | Please enter second number: 12 | And so: 43 + 12 = 55
            Console.WriteLine("Please enter a number: "); 
            string userInput = Console.ReadLine(); // Please enter a number: 3

            var num1 = 5;
            var num2 = 0;

            try
            {
                int division = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero"); // Can't divide by zero
            }

            try
            {
                int parsedInputValue = Int32.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter a digit");
            }
            catch (OverflowException)
            {
                //throw;
                Console.WriteLine("Overflow exception, the number was too long or too short for Int32");
            }
            catch (ArgumentNullException)
            {
                //throw;
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyway"); // This is called anyway
            }

            var num3 = 5;
            int num4;

            num4 = -num3;
            Console.WriteLine("num4 is {0}", num4);
            Console.WriteLine("num4 is {0}", num4++);
            Console.WriteLine("num4 is {0}", ++num4);
            //Console.ReadKey();
        }

        public static void GreetFriend(string friendName, string friendName2, string friendName3)
        {
            Console.WriteLine("Hi " + friendName + ", my friend");
            Console.WriteLine("Hi " + friendName2 + ", my friend");
            Console.WriteLine("Hi " + friendName3 + ", my friend");
        }
        // access modifier (static), return type, method name (par1, par2)
        public static void WriteSomething()
        {
            Console.WriteLine("Hello! I am called from a method :)");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double Calculate()
        {
            Console.WriteLine("Please enter first number: ");
            string number1Input = Console.ReadLine();
            int number1 = int.Parse(number1Input);
            Console.WriteLine("Please enter second number: ");
            string number2Input = Console.ReadLine();
            int number2 = int.Parse(number2Input);
            int result = number1 + number2;
            Console.WriteLine($"And so: {number1} + {number2} = {result}");
            return result;
        }
    }
}
