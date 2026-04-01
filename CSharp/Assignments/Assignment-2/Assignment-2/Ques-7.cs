using System;

namespace Assignment_2
{
    internal class Ques_7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string reverse = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }

            Console.WriteLine("Reversed: " + reverse);
        }
    }
}