using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};
            
                IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L")).ToList();
                foreach(string fruit in LFruits)
                {
                    Console.WriteLine(fruit);
                }

            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);
            foreach(int number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }

        }
        
    }
}
