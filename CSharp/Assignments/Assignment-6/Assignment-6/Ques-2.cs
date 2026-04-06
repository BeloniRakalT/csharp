using System;
using System.IO;

namespace Assignment_6
{
    internal class Ques_2
    {
        static void Main(string[] args)
        {
            // Array of strings
            string[] lines = {
                "C# is powerful",
                "File handling is easy",
                "This is Assignment 6",
                "Writing to file",
                "Reading from file"
            };

            // File path
            string filePath = "sample.txt";

            // Write to file
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Data written to file successfully.\n");

            // Read from file
            string[] readLines = File.ReadAllLines(filePath);

            Console.WriteLine("Reading data from file:\n");
            foreach (string line in readLines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}