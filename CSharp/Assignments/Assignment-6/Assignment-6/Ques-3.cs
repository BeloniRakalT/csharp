using System;
using System.IO;

namespace Assignment_6
{
    internal class Ques_3
    {
        static void Main(string[] args)
        {
            string filePath = "sample.txt";

            // Check if file exists
            if (File.Exists(filePath))
            {
                // Read all lines and count them
                int lineCount = File.ReadAllLines(filePath).Length;

                Console.WriteLine("Number of lines in the file: " + lineCount);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            Console.ReadLine();
        }
    }
}