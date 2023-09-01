using System;
using System.Collections.Generic;
using System.Text;

namespace MoreStruct
{
    internal class MethodParameters
    {
        public static void ChangeHeight( myRectangle rectangle1)
        {
            rectangle1.Height = 500;
            Console.WriteLine($"rectangle1 height is : {rectangle1.Height}");
        }
    }
}
