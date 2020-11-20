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

            List<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0).ToList();
            fourSixMultiples.ForEach(numbers => Console.WriteLine(numbers));

            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names.OrderByDescending(name => name).ToList();
            descend.ForEach(name => Console.WriteLine(name));


            List<int> numbersCollection = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };


            List<int> numbersAscending = numbersCollection.OrderBy(number => number).ToList();

            numbersAscending.ForEach(number => Console.WriteLine(number));

            
            List<int> numbersList = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

           Console.Write(numbersList.Count);

            
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double Profit = purchases.Sum();
            Console.WriteLine(Profit);
            
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double highestPrice = prices.Max();
            Console.WriteLine(highestPrice);

            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            int firstPerfSquare = wheresSquaredo.First(number => Math.Sqrt(number) % 1 == 0);
            Console.WriteLine(firstPerfSquare);

        }


        
    }
}
