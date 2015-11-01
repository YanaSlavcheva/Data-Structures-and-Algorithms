using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem07_NumbersOccurencies
{
    class NumbersOccurencies
    {
        static void Main(string[] args)
        {
            //Write a program that finds in given array of integers (all belonging to the range[0..1000])
            //how many times each of them occurs.

           List<int> numbers = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            Dictionary<int, int> occurencies = new Dictionary<int, int>();
            GetOccurenciesForEachNumber(numbers, occurencies);

            var keys = occurencies.Keys.ToList();
            keys.Sort();

            foreach (var key in keys)
            {
                Console.WriteLine("{0} -> {1} times", key, occurencies[key]);
            }
        }

        private static void GetOccurenciesForEachNumber(List<int> numbers, Dictionary<int, int> occurencies)
        {
            foreach (int number in numbers)
            {
                if (occurencies.ContainsKey(number))
                {
                    occurencies[number]++;
                }
                else
                {
                    occurencies.Add(number, 1);
                }
            }
        }
    }
}