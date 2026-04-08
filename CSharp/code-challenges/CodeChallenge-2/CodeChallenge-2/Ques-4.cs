using System;

namespace CodeChallenge_2
{
    internal class Ques_4
    {
        // Declare delegate
        public delegate int Calculator(int a, int b);

        // Methods for operations
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method that takes delegate as argument
        public static void PerformOperation(int x, int y, Calculator calc)
        {
            int result = calc(x, y);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            // Take input
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Create delegate objects
            Calculator add = Add;
            Calculator sub = Subtract;
            Calculator mul = Multiply;

            // Display results neatly
            Console.WriteLine("\nResults:\n");
            Console.WriteLine("Addition       : " + add(num1, num2));
            Console.WriteLine("Subtraction    : " + sub(num1, num2));
            Console.WriteLine("Multiplication : " + mul(num1, num2));

            Console.ReadLine();
        }
    }
}