using System;
using System.Collections.Generic;

namespace HelloWorldExampleproj
{
    class Program
    {
        public static void Main(String[] args) //string[] args // First line is the C# first main method 
        {
            //Console.WriteLine("Hello World");  //Coding exercise: Add code to the HelloWorld() function that will log the string "Hello World" to the C# console. On udemy though :"System.Console.WriteLine("Hello World");" 
            //System.Diagnostics.Debug.WriteLine("Hello World");

            //List<string> collection = new List<string>() { "a", "b", "c", "d" };

            //for(int i = 0; i < collection.Count; i++)               //going through the list of collection with a for loop
            //{
            //    Console.WriteLine(collection[i]);
            //}
          


            //While loop demonstration

            int k = 3;
            while(k > 0)
            {
                Console.WriteLine("loading"); //once k reaches 0 the code will stop executing 
                k--;
            }


            Console.ReadLine();

        }
    }
}
