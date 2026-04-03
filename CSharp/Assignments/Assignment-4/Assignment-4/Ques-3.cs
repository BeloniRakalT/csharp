using System;
using System.Collections.Generic;

namespace Assignment_4
{
    internal class Ques_3
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements:");

            for (int i = 0; i < n; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                stack.Push(value);
            }

            // Convert stack to list
            List<int> list = new List<int>(stack);

            // Sort in descending order
            list.Sort();
            list.Reverse();

            // Create new stack with sorted values
            Stack<int> sortedStack = new Stack<int>();

            foreach (int item in list)
            {
                sortedStack.Push(item);
            }

            Console.WriteLine("Stack elements in descending order:");

            foreach (int item in sortedStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}