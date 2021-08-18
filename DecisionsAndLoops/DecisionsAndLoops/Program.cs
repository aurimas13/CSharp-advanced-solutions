using System;

namespace DecisionsAndLoops
{
    class MainClass
    {
        static string username;
        static string password;

        public static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            //int numTemp = int.Parse(temperature);
            int numTemp;
            int number;

            if (int.TryParse(temperature, out number)) // to avoid crashes through Parse method using tryParse solves error values when you enter a tring instead of anumber for example
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered was not a number, so it was set to 0");
            }

            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat!");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Cosy & Warm. Pants and pull over will be fine");
            }
            else if (numTemp >= 30)
            {
                Console.WriteLine("It's burning. Stay home to keep cold.");
            }
            else
            {
                Console.WriteLine("Shorts are enough today");
            }

            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username: ");
            userName = Console.ReadLine();
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user");
                Console.WriteLine("Hi there, " + userName);
                Console.WriteLine("Hi there admin");
            }
            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You're logged in");
            }
            Register();
            Login();


            int temperature_two = -5;
            string stateOfMatter, stateOfMatter2;
            stateOfMatter = temperature_two < 0 ? "solid" : "liquid"; // enhances if statement
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            temperature_two += 130;
            stateOfMatter2 = temperature_two > 100 ? "gas" : temperature_two < 0 ? "solid" : "liquid"; // enhances if statement
            Console.WriteLine("State of matter is {0}", stateOfMatter2);

            Console.WriteLine("What's the temperature?");
            var inputValue = Console.ReadLine();
            int inputTemperature = 0;
            string temperatureMessage = string.Empty;
            bool validInteger = int.TryParse(inputValue, out inputTemperature);
            if (validInteger)
            {
                temperatureMessage = inputTemperature <= 15 ?
                    // true
                    "It is too cold here" :
                    // false
                    (inputTemperature >= 16 && inputTemperature <= 28) ?
                    // true
                    "It is cold here" :
                    // false
                    inputTemperature > 28 ?
                    // true
                    "It is hot here" :
                    // false
                    "";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                Console.WriteLine("Not a valid temperature");
            }
        }

        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration complete");
            Console.WriteLine("----------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username");
            }
        }
    }
}