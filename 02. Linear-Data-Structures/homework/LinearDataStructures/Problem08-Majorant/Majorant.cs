using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem08_Majorant
{
    class Majorant
    {
        static void Main(string[] args)
        {
            //*The majorant of an array of size N is a value that occurs in it at least N/ 2 + 1 times.
            //Write a program to find the majorant of given array (if exists).

            List<int> numbers = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            var neededOccurencies = numbers.Count/2 + 1;

            Dictionary<int, int> occurencies = new Dictionary<int, int>();
            GetOccurenciesForEachNumber(numbers, occurencies);

            var keys = occurencies.Keys.ToList();
            keys.Sort();

            foreach (var key in keys)
            {
                if (occurencies[key] >= neededOccurencies)
                {
                    Console.WriteLine(key);
                }
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