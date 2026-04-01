using System;

namespace Assignment_2
{
    internal class Ques_1
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
}