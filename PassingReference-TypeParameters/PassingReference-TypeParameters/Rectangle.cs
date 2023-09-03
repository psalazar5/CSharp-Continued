﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingReference_TypeParameters
{
    public struct Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            this.Width = width; 
            this.Height = height;   
        }

    }
}
