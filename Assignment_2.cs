using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call any one at a time to see output

            PatternDisplay.Run();
            DayName.Run();

            ArrayBasics.Run();
            MarksAnalysis.Run();
            ArrayCopy.Run();

            StringLength.Run();
            StringReverse.Run();
            StringCompare.Run();
        }
    }

    // 1. Pattern Display
    class PatternDisplay
    {
        public static void Run()
        {
            Console.Write("Enter a digit: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }

    // 2. Day Name
    class DayName
    {
        public static void Run()
        {
            Console.Write("Enter day number: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Invalid input"); break;
            }
        }
    }

    // Array Basics
    class ArrayBasics
    {
        public static void Run()
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            int sum = 0, min = arr[0], max = arr[0];

            foreach (int n in arr)
            {
                sum += n;
                if (n < min) min = n;
                if (n > max) max = n;
            }

            Console.WriteLine("Average: " + (sum / arr.Length));
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
        }
    }

    // Marks Analysis
    class MarksAnalysis
    {
        public static void Run()
        {
            int[] marks = new int[10];
            int sum = 0;

            Console.WriteLine("Enter 10 marks:");

            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
            }

            int min = marks[0], max = marks[0];

            foreach (int m in marks)
            {
                if (m < min) min = m;
                if (m > max) max = m;
            }

            // Sorting (ascending)
            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[i] > marks[j])
                    {
                        int temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
            }

            Console.WriteLine("Total: " + sum);
            Console.WriteLine("Average: " + (sum / 10));
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);

            Console.WriteLine("Ascending:");
            foreach (int m in marks)
                Console.Write(m + " ");

            Console.WriteLine("\nDescending:");
            for (int i = marks.Length - 1; i >= 0; i--)
                Console.Write(marks[i] + " ");
        }
    }

    // Array Copy
    class ArrayCopy
    {
        public static void Run()
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] dest = new int[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                dest[i] = source[i];
            }

            Console.WriteLine("Copied Array:");
            foreach (int n in dest)
                Console.Write(n + " ");
        }
    }

    // String Length
    class StringLength
    {
        public static void Run()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Length: " + word.Length);
        }
    }

    // String Reverse
    class StringReverse
    {
        public static void Run()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] arr = word.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine("Reversed: " + new string(arr));
        }
    }

    // String Compare
    class StringCompare
    {
        public static void Run()
        {
            Console.Write("Enter first word: ");
            string w1 = Console.ReadLine();

            Console.Write("Enter second word: ");
            string w2 = Console.ReadLine();

            if (w1.Equals(w2))
                Console.WriteLine("Both are same");
            else
                Console.WriteLine("Different words");
        }
    }
}