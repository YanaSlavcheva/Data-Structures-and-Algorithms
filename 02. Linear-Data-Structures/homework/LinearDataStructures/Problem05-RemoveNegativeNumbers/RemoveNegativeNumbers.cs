using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem05_RemoveNegativeNumbers
{
    class RemoveNegativeNumbers
    {
        static void Main(string[] args)
        {
            //Write a program that removes from given sequence all negative numbers.

            List<int> numbers = new List<int> {1, 2, -4, 5, -7, -18, 23};
            numbers = numbers.Where(x => x >= 0).ToList();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}