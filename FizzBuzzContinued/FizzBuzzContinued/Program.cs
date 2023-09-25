using System;

namespace FizzBuzzContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz Example 

            //Assignment : Loop through an array with numbers 1 - 100 
            // When divisible by 3, print "Fizz"
            // When divisible by 5, print "Buzz"
            //When divisible by both, print "FizzBuzz"

            //PsuedoCode: 
            //GIVEN COLLECTION 1-100 
            //FOR EACH NUMBER X IN COLLECTION 
            //      IF X DIVISBLE BY 3 AND 5    
            //          OUTPUT "Fizzbuzz" 
            //      ELSE IF X DIVISBLE BY 3 
            //          OUTPUT "Fizz"
            //      ELSE IF X DIVISIBLE BY 5
            //          OUTPUT "Buzz"
            //      END IF 
            //END FOR EACH 

            //create the array to work with 

            int[] array = new int[100]; 
            for(int c = 1; c <= 100; c++)
            {
                array[c - 1] = c;
            }

            Console.WriteLine("Array Populated");

            //Set up the loop 
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("Element " + i + " contains integer " + array[i]);
            //}


            //Solve the "divisible by both 5" part first 

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 3 == 0 && array[i] % 5 == 0) //making sure to put these in order 
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (array[i] % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (array[i] % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(array[i]);
            //    }

            //}

            // Solve the divisible by "3" part first 
            //for(int i = 0; i < array.Length; i++)
            //{
            //    if(array[i] % 3 == 0) //modulus : check the result of whats left over after dividing by number after it 
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(array[i]);
            //    }
            //}

            //Solve the divisible by "5" part first 

            //for(int i = 0; i < array.Length; i++)
            //{
            //    if(array[i] % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (array[i] % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(array[i]);
            //    }
            //}

            //Conclusion 

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0 && array[i] % 5 == 0) //making sure to put these in order 
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (array[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (array[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }

            }

            //Better Solutions: 

            //Using the "foreach" construct if it's available
            //foreach (int item in array)
            //{
            //    if(item % 3 == 0 && item % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (item % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (item % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Outside the box solution(Did they SAY we had to print the numbers that dont meet the specs?)

            //foreach (int item in array)
            //{
            //    if(item % 3 == 0)
            //    {
            //        Console.Write("Fizz");
            //    }
            //    if(item % 5 == 0)
            //    {
            //        Console.Write("Buzz");
            //    }
            //}

            Console.ReadLine();


            //PRACTICE// 

            //int[] array = new int[100];

            //for (int w = 1; w <= 100; w++)
            //{
            //    array[w - 1] = w;
            //}
            //Console.WriteLine("Array populated ");

            //int[] array1 = new int[100];
            //for (int e = 1; e <= 100; e++)
            //{
            //    array1[e - 1] = e;
            //}

            //int[] array2 = new int[100];
            //for (int q = 0; q <= 100; q++)
            //{
            //    array[q - 1] = q;
            //}

            //Console.WriteLine("array pop");



            //int[] array3 = new int[100];
            //for (int p = 1; p <= array3.Length; p++)
            //{
            //    array[p - 1] = p;
            //}


            //int[] array4 = new int[100];
            //for (int d = 1; d <= 100; d++)
            //{
            //    array[d - 1] = d;
            //}

            //int[] array5 = new int[100];
            //for (int u = 0; u <= 100; u++)
            //{
            //    array[u - 1] = u;
            //}
            //for (int y = 0; y <= array.Length; y++)
            //{
            //    if (array[y] % 3 == 0 && array[y] % 5 == 0)
            //    {
            //        Console.WriteLine("fizzbuzz");
            //    }
            //    else if (array[y] % 3 == 0)
            //    {
            //        Console.WriteLine("fizz");
            //    }
            //    else if (array[y] % 5 == 0)
            //    {
            //        Console.WriteLine("buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(array[y]);
            //    }
            

        }           
    }
}
