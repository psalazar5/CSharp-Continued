using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        { //Given a string, reverse it 
            string input = "Hello World";
            string reversed = ReverseString(input); //The name ReverseString doesnt exist in the current context, so I implimented GenerateMethod.ReverseString.
            Console.WriteLine(reversed); //In this example, the ReverseString method takes a string input as a parameter.
            Console.ReadLine();
        }// It converts the string into a character array using the ToCharArray method.  Then, it reverses the character array using the Array.Reverse method.
        // Finally, it creates a new string from the reversed character array using the new string(char[]) constructor and returns it.

        
        private static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }

    }
}
