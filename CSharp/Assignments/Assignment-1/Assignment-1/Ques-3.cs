using System;

namespace Assignment_1
{
    internal class Ques_3
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operation;

            Console.Write("Input first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input operation (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    else
                        Console.WriteLine("Division by zero is not allowed.");
                    break;

                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }
    }
}