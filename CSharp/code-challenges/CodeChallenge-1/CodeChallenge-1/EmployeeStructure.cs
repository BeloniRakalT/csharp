using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_1
{
    internal class EmployeeStructure
    {
        // Nested struct for Date of Birth
        public struct DateOfBirth
        {
            public int Day;
            public int Month;
            public int Year;
        }

        // Main Employee struct containing another struct
        public struct Employee
        {
            public string Name;
            public DateOfBirth DOB;
        }

        static void Main(string[] args)
        {
            Employee[] emp = new Employee[2];

            for (int i = 0; i < emp.Length; i++)
            {
                Console.Write("Name of the employee : ");
                emp[i].Name = Console.ReadLine();

                Console.Write("Input day of the birth : ");
                emp[i].DOB.Day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input month of the birth : ");
                emp[i].DOB.Month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input year for the birth : ");
                emp[i].DOB.Year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine($"Name: {emp[i].Name}");
                Console.WriteLine($"DOB: {emp[i].DOB.Day}/{emp[i].DOB.Month}/{emp[i].DOB.Year}");
                Console.WriteLine();
            }
        }
    }
}