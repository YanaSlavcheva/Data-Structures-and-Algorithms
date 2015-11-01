namespace Problem2_ReverseIntegers
{
    using System;
    using System.Collections.Generic;

    class ReverseIntegers
    {
        static void Main(string[] args)
        {
            /*Write a program that reads N integers from the console and reverses them using a stack.
            Use the Stack < int > class.*/

            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Push(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}