using System;

namespace CodeChallenge_2
{
    
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }
        public abstract bool IsPassed(double grade);
    }

    
    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    
    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Undergraduate ug = new Undergraduate()
            {
                Name = "Alice",
                StudentId = 1,
                Grade = 75.5
            };

            
            Graduate grad = new Graduate()
            {
                Name = "Bob",
                StudentId = 2,
                Grade = 78.0
            };

            
            Console.WriteLine("Undergraduate Student:");
            Console.WriteLine($"Name: {ug.Name}, Passed: {ug.IsPassed(ug.Grade)}");

            
            Console.WriteLine("\nGraduate Student:");
            Console.WriteLine($"Name: {grad.Name}, Passed: {grad.IsPassed(grad.Grade)}");

            Console.ReadLine();
        }
    }
}