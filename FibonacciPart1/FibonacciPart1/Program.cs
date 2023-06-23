using System;

namespace FibonacciPart1
{
    class Program
    {
        //The Fibonacci sequence is a series of numbers where the next term is the sum of the previous two terms 
        //Formula: fn = f(n-1) + f(n-2)
        //The first two terms of the Fibonacci sequence is 0 followed by 1 . 0 1 1 2 3 5 8 13 21 34
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide input value");
            int count = Int32.Parse(Console.ReadLine());
            Console.Write(p1 + " " + p2);
            
            

            //for(int i = 2; i < count; i++)
            //{
            //    p3 = p1 + p2;
            //    Console.Write(" " + p3);
            //    p1 = p2;
            //    p2 = p3;
            //}
            //Console.ReadLine();

            Fibonacci(count - 2);
            Console.ReadLine();
        }

        private static void Fibonacci(int count)
        {
            if(count > 0)
            {
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;
                Fibonacci(--count);
            }
        }
    }
}
