using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Interview2exercise
{
    class sumArray
    {
        public static BigInteger SumofArray(int[] numbers)
        {
            BigInteger sum = 0; 
            foreach(int number in numbers)
            {
                sum += number; 
            }
            return sum; 
        }
    }
}
