using System;

namespace FibonacciPart1
{
    class Program
    {
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
