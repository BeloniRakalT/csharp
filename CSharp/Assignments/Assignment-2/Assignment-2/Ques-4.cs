using System;

namespace Assignment_2
{
    internal class Ques_4
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            int sum = 0;

            Console.WriteLine("Enter 10 marks:");

            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
            }

            int min = marks[0], max = marks[0];

            foreach (int m in marks)
            {
                if (m < min) min = m;
                if (m > max) max = m;
            }

            Console.WriteLine("Total: " + sum);
            Console.WriteLine("Average: " + (sum / 10));
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);

            // Ascending
            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[i] > marks[j])
                    {
                        int temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
            }

            Console.WriteLine("Ascending:");
            foreach (int m in marks) Console.Write(m + " ");

            Console.WriteLine();

            Console.WriteLine("Descending:");
            for (int i = marks.Length - 1; i >= 0; i--)
                Console.Write(marks[i] + " ");
        }
    }
}