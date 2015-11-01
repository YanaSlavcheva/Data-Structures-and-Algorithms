namespace Problem04_LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestSubsequence
    {
        static void Main(string[] args)
        {
            //Write a method that finds the longest subsequence of equal numbers
            //in given List and returns the result as new List<int>.
            //Write a program to test whether the method works correctly.

            // Uncomment if you want to test with your own input
            //List<string> numbersAsStrings = new List<string>();
            //var inputLine = Console.ReadLine();

            //numbersAsStrings = inputLine.Split(',').ToList();
            //List<double> numbers = numbersAsStrings.Select(double.Parse).ToList();

            // Hardcoded input
            List<double> numbers = new List<double> { 1, 5, 2, 2, 3, 3, 3, 5, 5};

            List<double> result = FindLongestSubsequenceOfEqualNumbers(numbers);
            Console.WriteLine(string.Join(", ", result));

        }

        private static List<double> FindLongestSubsequenceOfEqualNumbers(List<double> numbers)
        {
            int maxSequenceLength = 1;
            int maxSequenceStartIndex = 0;

            int currentSequenceLength = 1;
            int currentSequenceStartIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequenceLength++;
                }
                else
                {
                    if (currentSequenceLength > maxSequenceLength)
                    {
                        maxSequenceStartIndex = currentSequenceStartIndex;
                        maxSequenceLength = currentSequenceLength;
                    }

                    currentSequenceStartIndex = i;
                    currentSequenceLength = 1;
                }
            }

            return numbers.GetRange(maxSequenceStartIndex, maxSequenceLength);
        }
    }
}