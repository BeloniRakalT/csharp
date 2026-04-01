using System;

namespace Assignment_2
{
    internal class Ques_2
    {
        static void Main(string[] args)
        {
            int day;

            Console.Write("Enter day number (1-7): ");
            day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Invalid day number"); break;
            }
        }
    }
}