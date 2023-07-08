using System;

namespace ZTMConsoleApp
{
    internal class Program
    {
        //static int p1 = 0, p2 = 1, p3;

        static void Main(string[] args)
        {
            bool endProgram = false;
            do
            {
                Console.WriteLine("---- Calculator Menu ----");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit Program");

                Console.WriteLine("Enter your choice (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Calculate("addition");
                        break;
                    case 2:
                        Calculate("subtraction");
                        break;
                    case 3:
                        Calculate("multiplication");
                        break;
                    case 4:
                        Calculate("division");
                        break;
                    case 5:
                        endProgram = true;
                        break;
                    default:
                        Console.WriteLine("Error: Invalid choice. Please enter a number from 1 - 5.");
                        break;
                }
                Console.WriteLine();

            }
            while (!endProgram);
        }

        static void Calculate(string calculator)
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch(calculator)
            {
                case "addition": 
                    result = num1 + num2;
                    break;
                case "subtraction":
                    result = num1 - num2;
                    break;
                case "multiplication":
                    result = num1 * num2;
                    break;
                case "division":
                    if(num2 != 0 || num1 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error : Cannnot divid by zero.");
                        break;
                    }
                    break;
                default: throw new InvalidOperationException("Invalid calculation method.");
                
            }
            Console.WriteLine($"Result : {result}");
        }
    }
    
}
        // Random Practice ! 
            // Fizz Buzz
               //int[] array = new int[100];
            //for (int i = 1; i <= 100; i++)
            //{
            //    array[i - 1] = i;
            //}
            //for (int a = 0; a < array.Length; a++)
            //{
            //    if (array[a] % 3 == 0 && array[a] % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (array[a] % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (array[a] % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(array[a]);
            //    }


            //recursion factor 

            //Console.WriteLine( "enter a number");
            //int numberValue = Int32.Parse(Console.ReadLine());
            //for (int s = 1; s < numberValue ; s++)
            //{
            //    int fact = 1; 
            //    for(int f = 1; f < s; f++)
            //    {
            //        fact = fact * 1;
            //    }
            //    Console.WriteLine( "{0}! is {1}", numberValue, s);
            //}


            // fabonacci 
            //Console.WriteLine( "enter ur number");
            //int numberInput = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(p1 + " " + p2);
            //for(int d = 2; d < numberInput; d++)
            //{
            //    p3 = p1 + p2;
            //    Console.WriteLine(" " + p3);
            //    p1 = p2;
            //    p2 = p3;
            //}
            //Console.ReadLine();

            /* Define a loop that defines a variable with the value 0 and stops at 20. Increase the value of the variable at every iteration.
             * Decide what loop fits this problem best. Print a message to the console, including the variable's value for every iteration. */

            //int variable = 0;
            //while (variable < 20)
            //{
            //    Console.WriteLine($"Variable value : {variable}");
            //    variable++;
            //}

            /* Extend the previously created solution by only printing a message for values higher than 10. Decide what building block suits this problem best.
             */

            //int variable = 0;
            //while (variable < 20)
            //{
            //    Console.WriteLine($"Variable value : {variable}");
            //    variable++;
            //    if (variable < 10)
            //    {
            //        Console.WriteLine("");
            //    }
            //}

            //Write a program that prints a happy birthday based on user input. Ask the user for his age and reply on the console with a happy birthday message mentioning the user input.

            //Console.WriteLine("What is your age??");
            //string theirAge = Int32.Parse(Console.ReadLine());

            //Console.WriteLine($"Happy birthday! You are now {theirAge} years old!");

 