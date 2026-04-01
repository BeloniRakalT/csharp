using System;

namespace Assignment_2
{
    internal class Ques_3
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            int sum = 0, min = arr[0], max = arr[0];

            foreach (int num in arr)
            {
                sum += num;

                if (num < min) min = num;
                if (num > max) max = num;
            }

            Console.WriteLine("Average: " + (sum / arr.Length));
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
        }
    }
}