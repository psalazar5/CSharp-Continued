using System;

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
            int width;
            int height;
            public Rectangle(int width, int height)
            {
                this.width = width;
                this.height = height;
            }

            public int GetArea()
            {
                return this.width * this.height;
            }
        }
        static void Main(string[] args)
        {
            IRectangle rectangle = new Rectangle(10, 15);
            int area = rectangle.GetArea();
            Console.WriteLine($"The area of rectangle is: {area.ToString()}");

            Console.ReadKey();
        }
    }
}
