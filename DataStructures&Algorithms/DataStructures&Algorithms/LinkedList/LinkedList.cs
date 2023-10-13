using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.LinkedList
{
    public class LinkedList
    {
        public Node First { get; set; }
        
        public void InsertFirst(int data)
        {
            //Create new node 
            Node newNode = new Node();
            //Put data in node 
            newNode.Data = data;
            //Put old node into next 
            newNode.Next = First;
            //Make first the new node (head) 
            First = newNode;
        }
    }
}
