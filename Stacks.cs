using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_2
{
    internal class Stacks
    {
        private int[] arr;
        private int top;
        private int capacity;

        public Stacks(int size)
        {
            capacity = size;
            arr = new int[capacity];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == capacity - 1;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full. Cannot push element.");
                return;
            }

            top++;
            arr[top] = value;
            Console.WriteLine("Pushed: " + value);
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot pop element.");
                return -1;
            }

            int value = arr[top];
            top--;
            Console.WriteLine("Popped: " + value);
            return value;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot peek element.");
                return -1;
            }

            return arr[top];
        }

        public bool Search(int value)
        {
            int originalTop = top;
            while (top >= 0)
            {
                if (arr[top] == value)
                {
                    Console.WriteLine("Element " + value + " found at index " + top);
                    return true;
                }
                top--;
            }

            Console.WriteLine("Element " + value + " not found in the stack.");
            top = originalTop; // Restore the original top value after the search
            return false;
        }
    }
}
