using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a C# program to implement a stack by using array with push and pop operations. 
             * Find the top element of the stack and check if the stack is empty or not.
             */

            /*
             * Use the above implemented stack to search for any element
             */

            int stackSize = 5;
            Stacks stack = new Stacks(stackSize);

            Console.WriteLine("Is stack empty? " + stack.IsEmpty());

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            Console.WriteLine("Is stack empty? " + stack.IsEmpty());
            Console.WriteLine("Is stack full? " + stack.IsFull());

            int topElement = stack.Peek();
            Console.WriteLine("Top element: " + topElement);

            int searchElement = 30;
            stack.Search(searchElement);

            searchElement = 60;
            stack.Search(searchElement);

            stack.Pop();
            stack.Pop();
            stack.Pop();

            Console.WriteLine("Is stack empty? " + stack.IsEmpty());
            Console.ReadKey();
        }
    }
}
