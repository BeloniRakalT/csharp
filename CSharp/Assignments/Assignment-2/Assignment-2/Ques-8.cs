using System;

namespace Assignment_2
{
    internal class Ques_8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter second word: ");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2))
                Console.WriteLine("Both words are same");
            else
                Console.WriteLine("Words are different");
        }
    }
}