using System;


namespace MoreStruct
{

    class Program
    {
        MethodParameters.ChangeHeight(rectangle1);

        interface IRectangle
        {
            int GetArea();
        }
        struct myRectangle : IRectangle 
        {
            double width;
            double height;
           
            public myRectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
                

            public int GetArea()
            {
                return (int)(this.width * this.height);
            }
        }
        static void Main(string[] args)
        {
            IRectangle rectangle = new myRectangle(10, 15);

            var rectangle1 = new myRectangle(200, 300);

            int area = rectangle.GetArea();


            Console.WriteLine($"The area of rectangle is: {area}");
            Console.WriteLine($"The height of rectangle1 is: {} ");

            Console.ReadKey();
        }
    }
}
