using System;

namespace Csharp_GettingStarted
{
    //public class Ex1 { }
    //public class Ex2 : Ex1 { } //Subclass is Ex1
    //-------------------------------------------------------------------------------------------------------------------------//

    //class Box  //Operator overloading demonstration 
    //{
    //    private int length;
    //    private int width;
    //    private int height;

    //    public Box(int length, int width, int height)
    //    {
    //        this.length = length; //this keyword references the class member variables, when we dont we reference the arguments passed into the constructor 
    //        this.width = width;
    //        this.height = height;
    //    }

    //    public int GetLength()
    //    {
    //        return length;
    //    }

    //    public int GetWidth()
    //    {
    //        return width;
    //    }

    //    public int GetHeight()
    //    {
    //        return height;
    //    }


    //    public static Box operator + (Box box1, Box box2)
    //    {
    //        return new Box(box1.GetLength() + box2.GetLength(),
    //                       box1.GetWidth() + box2.GetWidth(),
    //                       box1.GetHeight() + box2.GetHeight());
    //    }


    //}
      
    
    //-------------------------------------------------------------------------------------------------------------------------//

    class Program
    {
        static void Main(string[] args)
        {
            //Ex2 ex2Object = new Ex2(); //Ex2 object is Ex1 object since Ex1 is a subclass of Ex2
            //bool b = ex2Object is Ex1;   //is operator 
            //System.Diagnostics.Debug.WriteLine(b);

            //-------------------------------------------------------------------------------------------------------------------------//

            //string s1 = "abc";
            //object obj1 = s1;           
            //string s2 = obj1 as string;
            /*Sometimes we’re going to have to want to cast a variable of one type to another type.
             * The as operator helps us to avoid an invalid cast exception.
             * If the cast is valid, the as operator will return the object cast to the new type.
             *  If the cast is invalid, then the as operator will return null. */

            //-------------------------------------------------------------------------------------------------------------------------//

            //int x = 10;
            //int value = 20 ;
            //bool isGreater = x > value ? true : false; //Ternary Operator 

            //-------------------------------------------------------------------------------------------------------------------------//

            // Null Coalescing Operator - variable = left operand(if this is not null the variable is set to this value ) ?? right operand(if left operand is null, then the variable is set to this value )

            //object obj = null;
            //object obj2 = obj ?? new object();

            //-------------------------------------------------------------------------------------------------------------------------//

            // sizeof() operator 
            /* Used to obtain the size, in bytes, of compile time known resources. 
             * Reveals how many bytes of memory each type takes up. Takes up an int and returns an int */

            //System.Diagnostics.Debug.WriteLine(sizeof(char));
            //System.Diagnostics.Debug.WriteLine(sizeof(int));
            //System.Diagnostics.Debug.WriteLine(sizeof(bool));
            //System.Diagnostics.Debug.WriteLine(sizeof(long));
            //System.Diagnostics.Debug.WriteLine(sizeof(float));


            //-------------------------------------------------------------------------------------------------------------------------//

            //typeof() operator -  Not really used everyday in programming. Reveals what is going on under the hood. Allows us to get a type at compile time.Takes in a C# type, returns the .Net type

            //System.Diagnostics.Debug.WriteLine(typeof(int));
            //System.Diagnostics.Debug.WriteLine(typeof(string));
            //System.Diagnostics.Debug.WriteLine(typeof(bool));
            //System.Diagnostics.Debug.WriteLine(typeof(float));
            //System.Diagnostics.Debug.WriteLine(typeof(char));
            //System.Diagnostics.Debug.WriteLine(typeof(long));

            //-------------------------------------------------------------------------------------------------------------------------//

            //Operator overloading 

            //Box box1 = new Box(2, 2, 2);
            //Box box2 = new Box(2, 2, 2);
            //Box box3 = box1 + box2;
            //Console.WriteLine("Length: " + box3.GetLength()) ;
            //Console.WriteLine("Width: " + box3.GetWidth());
            //Console.WriteLine("Length: " + box3.GetHeight());
            //Console.ReadLine();


            //-------------------------------------------------------------------------------------------------------------------------//

            //C# keywords and contextual keywords: 
            /*keywords are reserved words that have a special meaning. 
             * They are recognized by the compiler, and cannot be used as variable names. 
             * We can use them as variable names if we prefix them with the @ symbol. Main keywords are anywhere in C# code. ::::
             * 
             * abstract, as, base, bool, break, byte, case, catch, char, checked, class, const, continue, decimal, default, delegate, do, double, else, enum, event, explicit, extern, false, finally, fixed, float, for..
             * foreach, goto, if, implicit, in, int, interface, internal, is, lock, long, namespace, new, null, object, operator, out, override, params, private, protected, public, readonly, ref, returnm, sbyte, sealed...
             * short, sizeof, stackalloc, static, string, struct, switch, this, throw, true, try, typeof, uint, ulong, unchecked, unsafe, ushort, using, using static, virtual, void, volatile, while.
             * 
             * Contextual keyword : only has certain meaning in the context of the program but can be used as a variable name outside of that context
             * New keywords are usually added as contextual keywords so that they dont break legacy programs :
             * 
             * add, alias, ascending, async, await, by, descending, dynamic, equals, from, get, global, group, into, join, let, nameof, on, orderby, partial(type), partial(method), remove, select, set, unmanaged(generic type constraint),
             * value, var, when(filter condition), where(generic type constraint), where(query clause), yield
             * 
             */




            //-------------------------------------------------------------------------------------------------------------------------//


        }

    }
}
