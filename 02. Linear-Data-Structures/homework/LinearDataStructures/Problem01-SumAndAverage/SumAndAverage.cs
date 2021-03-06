﻿namespace Problem01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumAndAverage
    {
        static void Main(string[] args)
        {
            /*Write a program that reads from the console a sequence of positive integer numbers.

            The sequence ends when empty line is entered.
            Calculate and print the sum and average of the elements of the sequence.
            Keep the sequence in List<int>.*/

            var inputLine = Console.ReadLine();
            List<int> numbers = new List<int>();

            while (!string.IsNullOrEmpty(inputLine))
            {
                numbers.Add(int.Parse(inputLine));

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Sum());
        }
    }
}