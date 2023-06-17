using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type sType = typeof(string);
            //System.Diagnostics.Debug.WriteLine(sType.FullName); // system.string is logged to the vs output window 

            //If we tried to convert a float into an int , information would be lost inside the float 

            System.Diagnostics.Debug.WriteLine(Math.Abs(3.7f)); /*round function is useful when we want to round a float to the next int 
                                                                 * cieling function rounds up, floor rounds down of the int / truncate just rounds down just like floor
                                                                 * min function returns the two nymbers passed in and picks the lowest#/ max is opposite of min*/
        }
    }
}
