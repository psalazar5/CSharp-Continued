using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.LinkedList
{
    public class LinkedList
    {
        public Node? First { get; set; }
        
        public void InsertFirst(int data)
         {
            //Create new node 
            Node newNode = new Node() ;
            //Put data in node 
            newNode.Data = data;
            //Put old node into next 
            newNode.Next = First;
            //Make first the new node (head) 
            First = newNode;
        }

        public Node DeleteFirst()
        {
            //Assign temporary variable  
            //#nullable disable 
            Node? temp = First;
            //Assign the next node 
            First = First?.Next;
            //return temp value 
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating through list...");
            //
            Node current = First;
            while(current != null)
            {
                current.DisplayNode();
                current = current.Next; //iterating through node 
            }

        }
        
        public void InsertLast(int data)
        {
            Node current = First;
            while(current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
        
     
    }
}
