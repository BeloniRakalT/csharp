using System;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter position to remove: ");
            int position = Convert.ToInt32(Console.ReadLine());

            if (position >= 0 && position < input.Length)
            {
                string result = input.Remove(position, 1);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid position!");
            }
        }
    }
}