using System;

namespace Assignment_2
{
    internal class Ques_5
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Copied array:");

            foreach (int num in arr2)
                Console.Write(num + " ");
        }
    }
}