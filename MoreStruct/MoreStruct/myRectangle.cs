using System;
using System.Collections.Generic;
using System.Text;

namespace MoreStruct
{
    struct myRectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public myRectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public int GetArea()
        {
            return (int)(this.Width * this.Height);
        }
    }
}
