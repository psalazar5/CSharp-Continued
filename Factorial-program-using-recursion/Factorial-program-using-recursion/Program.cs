using System;

namespace Factorial_program_using_recursion
{
    class Program
    {
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            /* The function itself is called recursive function. Formula : n! = n* (n-1)!
             * 5! = 5* (5-1)! 
                *5*4! => 5*4*(4-1)!
                *5*4*3*2*1 
              *0! = 1 */
            Console.WriteLine("Please provide upper bound value:");
            int upperbound = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= upperbound; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }

                Console.WriteLine("{0}! is {1}", i, fact);
            }

            Console.ReadLine();





            

            //PRACTICE -------------------------------------------//
            //Console.WriteLine("input a value ");
            //int number = Int32.Parse(Console.ReadLine());

            //for(int w = 1; w < number; w++)
            //{
            //    int fact1 = 1;

            //    for (int k = 1; k < w; k++)
            //    {
            //        fact1 = fact1 * k; 
            //    }
            //    Console.WriteLine("{0}! is {1}", w, fact1);
            //}


            //Console.WriteLine("Please put an input ");
            //int numberInput = Int32.Parse(Console.ReadLine());

            //for(int e = 1; e < numberInput; e++)
            //{
            //    int fact2 = 1;
            //    for(int o = 1; o < e; o++)
            //    {
            //        fact2 = fact2 * o;
            //    }
            //    Console.WriteLine("{0}! is {1}", e, fact2);
            //}


            ////Fizz buzz quick challenge practice 

            //int[] array = new int[100];
            //for(int w = 1; w <= 100; w++)
            //{
            //    array[w - 1] = w;
            //}
            //for(int q = 0; q < array.Length; q++)
            //{
            //    if(array[q] % 3 ==0 && array[q] % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (array[q] % 3  == 0 && array[q] == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (array[q] % 5 == 0 && array[q] % 3 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(array[q]);
            //    }
            //}

            //Fibonacci practice 

            //Console.WriteLine("Please input ");
            //int input = Int32.Parse(Console.ReadLine());

            //Console.WriteLine(p1 + " " + p2);

            //for(int i = 2; i < input; i++)
            //{
            //    p3 = p1 + p2;
            //    Console.WriteLine(" " + p3);
            //    p1 = p2;
            //    p2 = p3;
            //}
            //Console.ReadLine();


            //Console.WriteLine("Please enter number");
            //int numberInput = Int32.Parse(Console.ReadLine());

            //Console.WriteLine(p1+ " " + p2);
            
            //for(int i = 2; i < numberInput; i++)
            //{
            //    p3 = p1 + p2;
            //    Console.WriteLine(" " + p3 );
            //    p1 = p2;
            //    p2 = p3;
            //}
            //Console.ReadLine();

            //=======================================================//

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
