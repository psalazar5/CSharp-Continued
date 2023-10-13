using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; } //nullable reference type 
        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}
