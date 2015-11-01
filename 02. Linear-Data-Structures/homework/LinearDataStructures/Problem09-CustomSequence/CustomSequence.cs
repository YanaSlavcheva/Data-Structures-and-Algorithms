using System;
using System.Collections.Generic;

namespace Problem09_CustomSequence
{
    class CustomSequence
    {
        static void Main(string[] args)
        {
            //We are given the following sequence:

            //S1 = N;
            //S2 = S1 + 1;
            //S3 = 2 * S1 + 1;
            //S4 = S1 + 2;
            //S5 = S2 + 1;
            //S6 = 2 * S2 + 1;
            //S7 = S2 + 2;
            //...
            //Using the Queue < T > class write a program to print its first 50 members for given N.
            //Example: N= 2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

            int n = 2;
            int wantedNumberOfMembers = 50;
            Queue<int> queue = new Queue<int>();
            int counter = 1;
            
            queue.Enqueue(n);
            while (counter <= wantedNumberOfMembers)
            {
                var current = queue.Dequeue();
                Console.Write(current + " ");

                queue.Enqueue(current + 1);
                queue.Enqueue(current * 2 + 1);
                queue.Enqueue(current + 2);

                counter++;
            }
        }
    }
}