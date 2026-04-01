using System;

namespace Assignment_1
{
    internal class Ques_2
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
        }
    }
}