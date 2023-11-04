using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Stack
{
    public class Stack
    {
        public int MaxSize { get; set; } // Array stacks you need a max size to init array 
        public string[] stackArray { get; set; } //stackArray holds the array
        public int Top { get; set; } //keeps track of top.. pointer

        public Stack(int size)
        {
            //This holds constructor value 
            this.MaxSize = size;
            //Create array with size 
            this.stackArray = new string[MaxSize];
            //We give top -1 because array is zero index; If we don't it will skip first element
            this.Top = -1; 
        }

        public void Push(string item)
        {
            //Top is incrementing when adding an item 
            Top++;
            stackArray[Top] = item;
        }

        public string Pop(string item)
        {
            //Think placeholder 
            int old_top = Top;
            //decrement for the new top 
            Top--;
            return stackArray[old_top]; 

        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public bool isFull()
        {
            return MaxSize - 1 == Top;
        }
    }
}
