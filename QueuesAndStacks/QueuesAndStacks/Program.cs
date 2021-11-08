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

            //Console.WriteLine("Numbers in reverse: ");
            //foreach (int num in myStack)
            //{
            //    Console.WriteLine(num + " ");
            //}

            Console.WriteLine("Numbers in reverse (Other method): ");
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop() + " ");
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1); // first added and last in the list
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            queue.Enqueue(3); // first added and last in the list
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            queue.Enqueue(4);
            int queueItem = queue.Dequeue(); // removes the first item
            Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());

            while (queue.Count > 0)
            {
                // Dequeue() will return thje element that was removed from the queue
                Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());
                // print the queue count
                Console.WriteLine("Current queue count is : {0}", queue.Count);
            }

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceiveOrdersFromBranch1())
            {
                // add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                // add each order to the queue
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                // remove the order at the front of the queue and  store it in a variable called curentOrder
                Order currentOrder = ordersQueue.Dequeue();
                // process the order
                currentOrder.ProcessOrder();
            }

        }

        //  this method will create an array of orders and return it

        static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            return orders;
        }

    }


    class Order
    {
        public int OrderId { get; set; }

        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            // print the message
            Console.WriteLine($"Order {OrderId} procesed!");
        }
    }
}
