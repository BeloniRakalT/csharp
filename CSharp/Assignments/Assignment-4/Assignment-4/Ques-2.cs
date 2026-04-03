using System;

namespace Assignment_4
{
    internal class Ques_2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (input.Length > 1)
            {
                char first = input[0];
                char last = input[input.Length - 1];

                string middle = input.Substring(1, input.Length - 2);

                string result = last + middle + first;

                Console.WriteLine("Result: " + result);
            }
            else
            {
                // If string has only 1 character, return it as it is
                Console.WriteLine("Result: " + input);
            }
        }
    }
}