namespace Problem03_OrderAscending
{
    using System;
    using System.Collections.Generic;

    class OrderAscending
    {
        static void Main(string[] args)
        {
            //Write a program that reads a sequence of integers(List<int>) ending with an empty line
            //and sorts them in an increasing order.

            var inputLine = Console.ReadLine();
            List<int> numbers = new List<int>();

            while (!string.IsNullOrEmpty(inputLine))
            {
                numbers.Add(int.Parse(inputLine));

                inputLine = Console.ReadLine();
            }

            numbers.Sort();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}