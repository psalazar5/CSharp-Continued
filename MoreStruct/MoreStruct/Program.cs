using System;


namespace MoreStruct
{
    class Program
    { 
        static void Main(string[] args)
        {
            IRectangle rectangle = new myRectangle(10, 15);

            var rectangle1 = new myRectangle(200, 300);

            int area = rectangle.GetArea();

            MethodParameters.ChangeHeight( rectangle1);

            Console.WriteLine($"The area of rectangle is: {area}");
            Console.WriteLine($"The height of rectangle1 is: {rectangle1.Height} ");

            Console.ReadKey();
        }
    }
}
