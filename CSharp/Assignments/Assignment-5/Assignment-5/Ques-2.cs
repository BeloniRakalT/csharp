using System;

namespace Assignment_5
{
    // Custom Exception
    public class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message) { }
    }

    // Scholarship Class
    public class Scholarship
    {
        public double Merit(double marks, double fees)
        {
            if (marks >= 70 && marks <= 80)
                return fees * 0.20;
            else if (marks > 80 && marks <= 90)
                return fees * 0.30;
            else if (marks > 90)
                return fees * 0.50;
            else
                throw new InvalidMarksException("Marks not eligible for scholarship.");
        }
    }

    // Main Program
    internal class program
    {
        static void Main(string[] args)
        {
            Scholarship s = new Scholarship();

            try
            {
                Console.Write("Enter Marks: ");
                double marks = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Fees: ");
                double fees = Convert.ToDouble(Console.ReadLine());

                double scholarshipAmount = s.Merit(marks, fees);
                Console.WriteLine("Scholarship Amount: " + scholarshipAmount);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}