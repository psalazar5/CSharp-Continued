namespace ZTMConsoleApp
{
    internal class Program
    {
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            int[] array = new int[100];
            for(int i = 1; i <= 100; i ++)
            {
                array[i-1] = i;
            }
            for(int a = 0; a < array.Length; a++)
            {
                if (array[a] % 3 == 0 && array[a] % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (array[a] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (array[a] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(array[a]);
                }
               
            }

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
        }
    }
}