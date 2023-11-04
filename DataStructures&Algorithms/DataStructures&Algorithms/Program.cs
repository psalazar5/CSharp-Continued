//using DataStructures_Algorithms.ADT;
//using System.Collections;

//Stack ts = new Stack();
//Pokemon squirtle = new Pokemon(); // declaring data struct. a specific pokemon , abstraction / concrete implementation bc its repsentative of all pokemon
//-------------------------------------------------------------------------------------------------------------------------------------------------------------


//Arrays 
//Array Insertions & Deletions 

//Inserting at the end of an array 
//int[] newArray = new int[8];

//Make a var to keep the length b/c .Length is based off capacity and does not track actual index.
//int length = 0;

//This adds data for us
//for (int i = 0; i < 8; i++)
//{
//    //1 is optional 
//    newArray[length] = i + 1;
//    length++;
//}

//newArray[length] = 8;
//length++;

//Inserting at start of array

//for (int i = 6; i >= 0; i--)
//{
//    this moves over all values
//    newArray[i + 1] = newArray[i];
//}

//newArray[0] = 10;

//int value = 0;

//Inserting anywhere in array 

//for (int i = 6; i >= 2; i--)
//{
//    //Shift each element one position to the right 
//    newArray[i + 1] = newArray[i];
//}
//newArray[2] = 0;

//int value = 0;

//for(int i = 0; i < length; i++)
//{
//    Console.WriteLine(newArray[i]);
//}

//Deleting from end of array 

//int[] newarray = new int[6];

//int length = 0;

//for (int i = 0; i < 6; i++)
//{
//    newarray[length] = i;
//    length++;
//}
//length--;



//deleting anywhere from array (delete index 3)
//int[] newArray = new int[6];
//int length = 0;
//for(int i = 0; i < 6;i++)
//{
//    newArray[i] = i;
//    length++;
//}
//for(int i = 4; i < length; i++) // 1 up from 3 = 4 (wanting to remove index 3 )
//{
//    newarray[i - 1] = newarray[i];
//}
//length--;



//deletes from start of array 
//int[] deleteArray = new int[10];
//int length = 0; 
//for(int i = 0; i < 10; i++)
//{
//    deleteArray[length] = i + 1;
//    length++;
//}

//for (int i = 1; i < length; i++)
//{
//    newarray[i - 1] = newarray[i];
//}
//length--;

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine(newarray[i]);
//}




//insert index 3 out of index 10(anywhere)
//int[] array = new int[10]; //created array 
//int Length = 0;
//for (int i = 0; i < 10; i++)
//{
//    array[Length] = i + 1;
//    Length++;
//}

//for (int i = 8; i >= 3; i--)
//{
//    array[i + 1] = array[i];
//}

//array[3] = 20;
//int value = 0;



//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine(array[i]);
//}

//insert at start out of 8 index spots (so 7)

//int[] array = new int[8];
//int Length = 0; 
//for(int i = 0; i < 8; i++)
//{
//    array[Length] = i+1;
//    Length++;
//}

//for (int i = 6; i >= 0; i--)
//{
//    array[i + 1] = array[i];
//}
//array[0] = 30;
//int value = 0;


//delete at index 3 
//int[] Array = new int[10];

//int Length = 0; 

//for(int i = 0; i < 10; i++)
//{
//    Array[Length] = i;
//    Length++;
//}

//for(int i = 4; i < Length; i++)
//{
//    Array[i-1] = Array[i];
//}
//Length--;

//for(int i = 0; i < Length; i++)
//{
//    Console.WriteLine(Array[i]);
//}

//LinearSearch Array 

//int[] Array = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//bool LinearSearch(int[]Array, int key)
//{
//    for (int i = 0; i < Array.Length; i++)
//    {
//        if (Array[i] == key)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//Console.WriteLine(LinearSearch(Array,0));

//using DataStructures_Algorithms.Arrays;

//LinearSearch linearSearch = new LinearSearch();
//int key = 5;

//bool found = linearSearch.Search(linearSearch.array, key);


//Linked-List


//using DataStructures_Algorithms.LinkedList;

//Node nodeA = new Node();
//nodeA.Data = 123;

//Node nodeB = new Node();
//nodeB.Data = 234;

//Node nodeC = new Node();
//nodeC.Data = 344;

//Node nodeD = new Node();
//nodeD.Data = 386;

//nodeA.Next = nodeB; //almost like an objectified array 
//nodeB.Next = nodeC;
//nodeC.Next = nodeD;

//LinkedList linkedList = new LinkedList();
//linkedList.InsertFirst(100);
//linkedList.InsertFirst(300);
//linkedList.InsertFirst(500);
//linkedList.InsertFirst(700);

//linkedList.DeleteFirst();
//linkedList.DeleteFirst();

//linkedList.InsertLast(546);
//linkedList.InsertLast(3562);

//linkedList.DisplayList(); 

using DataStructures_Algorithms.Stack;
Stack<string> stack = new Stack<string>(10);


for (int i = 0; i < 3; i++)
{
 stack.Push("Squirtle");
 stack.Push("Pikachu");
 stack.Push("Charmander");
}

stack.Pop();
stack.Peek();

while (stack.Count > 0)
{
 var var = stack.Pop();
 Console.WriteLine(var);
}
