using System;
using System.Collections.Generic;

namespace Problem06_OddOccurNumbers
{
    class OddOccurNumbers
    {
        static void Main(string[] args)
        {
            //Write a program that removes from given sequence all numbers that occur odd number of times.

            List<int> numbers = new List<int> {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};

            Dictionary<int, int> occurencies = new Dictionary<int, int>();
            GetOccurenciesForEachNumber(numbers, occurencies);
            RemoveNumbersWithOddOccurencies(occurencies, numbers);

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void RemoveNumbersWithOddOccurencies(Dictionary<int, int> occurencies, List<int> numbers)
        {
            foreach (var pair in occurencies)
            {
                if (pair.Value % 2 != 0)
                {
                    bool areAnyNumbersLeft = true;
                    while (areAnyNumbersLeft)
                    {
                        areAnyNumbersLeft = numbers.Remove(pair.Key);
                    }
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