using System;
using System.Collections.Generic;

namespace Problem10_ShortestSequence
{
    class ShortestSequence
    {
        static void Main(string[] args)
        {
            //We are given numbers N and M and the following operations:

            //N = N + 1
            //N = N + 2
            //N = N * 2

            //Write a program that finds the shortest sequence of operations
            //from the list above that starts from N and finishes in M.
            int initialNumber = 5;
            int n = initialNumber;
            int m = 16;

            Queue<string> queueOfOperations = new Queue<string>();

            while ((n * 2) < m)
            {
                queueOfOperations.Enqueue("*");
                n *= 2;
            }

            while ((n + 2) < m)
            {
                queueOfOperations.Enqueue("+2");
                n += 2;
            }

            while ((n + 1) < m)
            {
                queueOfOperations.Enqueue("+1");
                n += 1;
            }

            Console.Write(initialNumber);
            foreach (var operation in queueOfOperations)
            {
                initialNumber = ApplyOperationFromQueue(initialNumber, operation);
                Console.Write(" -> {0}", initialNumber);
            }
        }

        private static int ApplyOperationFromQueue(int n, string operation)
        {
            switch (operation)
            {
                case "*":
                    n *= 2;
                    break;
                case "+2":
                    n += 2;
                    break;
                case "+1":
                    n += 1;
                    break;
            }

            return n;
        }
    }
}