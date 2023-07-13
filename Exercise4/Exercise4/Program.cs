using System;
using System.Collections.Generic; //Used the first two using statements
using System.Text;

namespace Exercise4
{
    class Program
    { //Given a string, remove any repeated letters 
        static void Main(string[] args)
        {
            string words = "You must be crazzzyyyy";
            string withoutDuplicates = RemoveDuplicates(words);
            Console.WriteLine(withoutDuplicates);
            Console.ReadLine();
        }

        private static string RemoveDuplicates(string words)
        {
            HashSet<char> uniqueChars = new HashSet<char>();
            StringBuilder result = new StringBuilder();

            foreach(char c in words)
            {
                if (uniqueChars.Add(c))
                {
                    result.Append(c);
                }
            }
                
            return result.ToString();
        }
    }
}
