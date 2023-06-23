using System;

namespace Factorial_program_using_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The function itself is called recursive function. Formula : n! = n* (n-1)!
             * 5! = 5* (5-1)! 
                *5*4! => 5*4*(4-1)!
                *5*4*3*2*1 
              *0! = 1 */
            Console.WriteLine("Please provide upper bound value:");
            int upperbound = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= upperbound; i++)
            {
                int fact = 1;
                for(int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }

                Console.WriteLine("{0}! is {1}", i, fact);
            }

            Console.ReadLine();


            //Console.WriteLine("Please provide factoral number: ");
            //int factNumber = Int32.Parse(Console.ReadLine());

            //int result = FactorialCalculation(factNumber);
            //Console.WriteLine("Result is: {0} ", result);
            //Console.ReadLine();
        }

        //static int fact = 1; 
        //private static int FactorialCalculation(int factNumber)
        //{

        //    if (factNumber > 0)
        //    {
        //        fact = factNumber*FactorialCalculation(factNumber-1); //factnumber input * factnumber-1 until it reaches 1
        //    }
        //    return fact; 
        //}
        
        
    }
}
