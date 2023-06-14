using System;
using System.Numerics; //BigInteger is a type provided by the 'System.Numerics' namespace that can handle arbitrarily large integers w/o using losing precision. 
namespace Interview2exercise //It dynamically allocates memory to accommodate the size of the integer values being operated on, allowing calculations with extremely large numbers.
{
    class Program
    {
        static void Main(string[] args)
        { //Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1000000000 };
            BigInteger sum = sumArray.SumofArray(numbers); //BigInteger represents and handles very large integers using the 'BigInteger' type
            Console.WriteLine("Sum of Array elements: " + sum);

            //Wrote not a method but inside the program.cs
            int sumtotal = 0;
            foreach(int item in numbers)
            {
                sumtotal += item;
            }
            Console.WriteLine(sumtotal); 
            //------------------------------------------//

            Console.ReadLine();
        }
    }
}
