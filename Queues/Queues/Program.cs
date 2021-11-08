// Created by Aurimas A. Nausedas on 08/18/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining a new stack
            Stack<int> stack = new Stack<int>();
            // add elements
            stack.Push(1);
            // Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(4);
            int myStackItem = stack.Pop();
            Console.WriteLine("Popped item is : {0}", myStackItem);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            while (stack.Count > 0)
            {
                // Pop() wil return an item that was deleted
                Console.WriteLine("The Top value {0} was removed from the stack", stack.Pop());
                // Print the stack count
                Console.WriteLine("Current stack count is : {0}", stack.Count);
            }

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            // defining a new stack of int
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("The numbers in the array are:");
            // For each number in our array
            foreach (int number in numbers)
            {
                // print it
                Console.WriteLine(number + " ");
                // push it into our stack(add)
                myStack.Push(number);
            }

            Console.WriteLine("Numbers in reverse: ");
            foreach (int num in myStack)
            {
                Console.WriteLine(num + " ");
            }

            Console.WriteLine("Numbers in reverse (Other method): ");
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop() + " ");
            }
        }
    }
}
