using System;

namespace Assignment_1
{
    internal class Ques_4
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}