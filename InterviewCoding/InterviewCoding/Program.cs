using System;

namespace InterviewCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of integers, write out a method to total the odd numbers

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sumOfOdds = OddNumberCalculator.SumOfOddNumbers(numbers);
            Console.WriteLine("Sum of odd numbers: " + sumOfOdds);
            Console.ReadLine();
        }
    }
}
