using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class Ques_2
    {
        static void Main()
        {
            List<string> words = new List<string> { "mum", "amsterdam", "bloom" };

            var result = words
                .Where(w => w.StartsWith("a") && w.EndsWith("m"));

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}