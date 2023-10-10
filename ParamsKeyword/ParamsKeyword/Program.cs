namespace ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double total = CheckOut(16, 27.36, 15);
            Console.WriteLine(total);
            Console.ReadLine();


            static double CheckOut(params double[] prices)
            {
                double total = 0; 
                foreach(var price in prices)
                {
                    total += price; 
                }
                return total;
            }

             
        }
    }
}