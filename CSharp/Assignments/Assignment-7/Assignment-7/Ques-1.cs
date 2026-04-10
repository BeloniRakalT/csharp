using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 7, 2, 30 };

        var result = numbers.Where(n => n * n > 20);

        foreach (var n in result)
        {
            Console.WriteLine(n + " - " + (n * n));
        }
    }
}