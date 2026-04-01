using System;

namespace Assignment_1
{
    internal class Ques_5
    {
        static void Main(string[] args)
        {
            int num1, num2, result;

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                result = (num1 + num2) * 3;
            }
            else
            {
                result = num1 + num2;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}