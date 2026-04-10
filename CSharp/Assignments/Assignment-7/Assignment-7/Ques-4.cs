using System;
using ClassLibrary1;

namespace Assignment_7
{
    internal class Ques_4
    {
        static void Main()
        {
            const int TotalFare = 500;

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Concession obj = new Concession();
            string result = obj.CalculateConcession(age);

            Console.WriteLine(result);
        }
    }
}