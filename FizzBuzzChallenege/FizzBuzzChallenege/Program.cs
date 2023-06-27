using System;

namespace FizzBuzzChallenege
{
    class Program
    {
        static void Main(string[] args)
        {
            //If the number is divisible by 3, print "Fizz" instead.
            //If the number is divisible by 5, print "Buzz" instead.
            //If the number is divisible by both 3 and 5, print "FizzBuzz".
            //Otherwise, simply print the number itself.

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            } 
            Console.ReadLine();
        }
    }
}
