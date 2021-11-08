// Created by Aurimas A. Nausedas on 08/18/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;
namespace OOP
{
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;
        private int age;
        private string eyeColor;
        // default constructor

        public Human()
        {
            Console.WriteLine("Constructor called. Object created.");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // parameterised constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }


        // member
        public void InroduceMyslef()
        {
            if (age != 0 && firstName != null && lastName != null && eyeColor != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} with {2} eyes of {3} years old.", firstName, lastName, eyeColor, age);
            }
            else if (age != 0 && firstName != null && lastName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} with of {2} years old.", firstName, lastName, age);
            }
            else if (firstName != null && lastName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
            }

            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} ", firstName);
            }
            else
            {
                Console.WriteLine("Hi, I'm {0} {1} with {2} eyes.", firstName, lastName, eyeColor);
            }
        }
    }
}

