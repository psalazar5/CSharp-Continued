using System;
using System.Drawing;

namespace MoreStruct
{
    class Program
    {
        interface IRectangle
        {
            int GetArea();
        }
        struct Rectangle : IRectangle
        {
            double width;
            double height;
           
            public Rectangle(double width, double height)
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
            IRectangle rectangle = new Rectangle(10, 15);
            var rectangle1 = new Rectangle(200,300);
            int area_Of_Rectangle = rectangle1.GetArea();
            int area = rectangle.GetArea();
            Console.WriteLine($"The area of rectangle is: {area.ToString()}");
            Console.WriteLine($"The area of rectangle1 is : {area_Of_Rectangle.ToString()}");

            Console.ReadKey();
        }
    }
}
