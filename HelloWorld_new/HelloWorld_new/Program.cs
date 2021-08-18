using System;

namespace HelloWorld_new
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring multiple variables
            int num3, num4, num5;
            // declaring a variable
            int number;
            // assigning a value to a variable
            number = 13;
            // declaring and initializing a variable in one go
            int number_two = 25;
            int sum = number + number_two;
            double d1 = 3.145543;
            double d2 = 5.111;
            double div = d1 / d2;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Enter a string and press enter: "); // Enter a string and press enter: Auris
            string read = Console.ReadLine();
            //Console.Clear();
            Console.WriteLine("Enter a first name and press enter: "); // Enter a first name and press enter:    Aurimas
            string yourName = Console.ReadLine();
            Console.WriteLine("Enter a surname and press enter: "); // Enter a surname and press enter: Nausedas
            string surname = Console.ReadLine();
            Console.WriteLine("Enter a character to search and press enter: "); // Enter a character to search and press enter: a
            char searchInput = Console.ReadLine()[0];
            int searchIndex = yourName.IndexOf(searchInput);
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex); // Index of character a in string is 10
            var fullName = string.Concat(yourName, " ", surname);
            Console.WriteLine("Full name is: " + fullName); // Full name is:      Aurimas Nausedas
            Console.WriteLine("Enter a string to search it's asciis number and press enter: "); // Enter a string to search it's asciis number and press enter: a
            int ascii = Console.Read();
            Console.WriteLine("You have entered {0} and {1}", read, ascii); // You have entered Auris and 97
            var yourNameUpperCase = String.Format("Upper case: {0}", yourName.ToUpper()); 
            var yourNameTrimmed = String.Format("Trimmed value: {0}", yourName.Trim()); 
            var yourNameSubstring = String.Format("Substring value: {0}", yourName.Substring(0, 10));    
            Console.WriteLine(yourNameUpperCase); // Upper case:      AURIMAS
            Console.WriteLine(yourNameTrimmed); // Trimmed value: Aurimas
            Console.WriteLine(yourNameSubstring); // Substring value:      Aurim
            Console.WriteLine("d1/d2 is " + div); // d1/d2 is 0.6154457053414205
            float f1 = 3.145543f;
            float f2 = 5.111f;
            float div2 = f1 / f2;
            Console.WriteLine("f1/f2 is " + div2); // f1/f2 is 0.61544573
            // declaring a string
            var string1 = "13"; 
            var string2 = "15"; // need to parse this string to int/float, etc.
            var string3 = "17";
            int number1 = Int32.Parse(string1);
            int number2 = Int32.Parse(string2);
            int number3 = int.Parse(string3);
            int result = number1 + number2 + number3;
            // string formatting
            Console.WriteLine("{0} + {1} + {2} = {3}", number1, number2, number3, result); // 13 + 15 + 17 = 45
            // string interpolation
            Console.WriteLine($"{number1} + {number2} + {number3} = {result}"); // 13 + 15 + 17 = 45
            // verbatim strings
            Console.WriteLine(@"Verbatim Strings:
My name is,
My name is,
Muahaha \n has no power here, but without @ it has,
My name is,

My name is,
My name is");
            string myname = "Aurimas";
            string message = "My name is " + myname;
            string capsMessage = message.ToUpper();
            Console.WriteLine(message); // My name is Aurimas
            Console.WriteLine(capsMessage); // MY NAME IS AURIMAS
        }
    }
}
