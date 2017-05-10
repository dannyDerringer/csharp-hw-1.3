using System;
using System.Collections.Generic;

namespace csharp_hw_1._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = new List<int> {7, 11, 111, 311, 411, 
            711, 911};

            int max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                max = Math.Max(max, numbers[i]);
            }

            Console.WriteLine("Current max = " + max);
        }

    }
}
