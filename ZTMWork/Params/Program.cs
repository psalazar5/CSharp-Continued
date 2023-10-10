
//var numberPrinter = new NumberPrinter();
//numberPrinter.printNumbers(new int[] { 1, 2, 3 });
//numberPrinter.printNumbers(4, 5, 6, 7);

//public class NumberPrinter
//{
//    public void printNumbers(params int[] numbers)
//    {
//        foreach(var number in numbers)
//        {
//            Console.WriteLine($"{numbers}");
//        }
//    }
//}


class program
{
    static void Main(string[] args)
    {
        //params keyword = a method parameter that takes a variable number of arguments . 
        //                  The parameter type must be a single - dimensional array.

        double total = CheckOut(3.99, 5.75, 15);
         
        Console.WriteLine(total);
        Console.ReadLine();

    }

    static double CheckOut(params double[] prices )
    {
        double total = 0;
        foreach(var price in prices)
        {
            //total = total + price;
            total += price;
        }
        return total;
    }


    //Example of what not to do and what to do ^^^^^ we do not need the several copies of the same method 

     
    //static double CheckOut(double a, double b)
    //{
    //    return a + b;
    //}
    
    //static double CheckOut(double a, double b, double c)
    //{
    //    return a + b + c;
    //}

    //static double CheckOut(double a, double b, double c, double d)
    //{
    //    return a + b + c + d;
    //}

    //static double CheckOut(double a, double b, double c, double d, double e)
    //{
    //    return a + b + c + d + e;
    //}

    //static double CheckOut(double a, double b, double c, double d, double e, double f)
    //{
    //    return a + b + c + d + e + f;
    //}


}