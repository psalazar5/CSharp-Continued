//using DataStructures_Algorithms.ADT;
//using System.Collections;

//Stack ts = new Stack();
//Pokemon squirtle = new Pokemon(); // declaring data struct. a specific pokemon , abstraction / concrete implementation bc its repsentative of all pokemon
//-------------------------------------------------------------------------------------------------------------------------------------------------------------


//Arrays 
//Array Insertions & Deletions 

//Inserting at the end of an array 
int[] newArray = new int[10];

//Make a var to keep the length b/c .Length is based off capacity and does not track actual index.
int length = 0;

//This adds data for us
for (int i = 0; i < 9; i++)
{
    //1 is optional 
    newArray[length] = i + 1;
    length++;
}

newArray[length] = 8;
length++;

//Inserting at start of array

//for(int i = 8; i >= 0; i--)
//{
//    //this moves over all values 
//    newArray[i + 1] = newArray[i];
//}

//newArray[0] = 20;

//int value = 0;

//Inserting anywhere in array 

//for (int i = 4; i >= 2; i--)
//{
//    //Shift each element one position to the right 
//    newArray[i + 1] = newArray[i];
//}
//newArray[2] = 0;

//int value = 0;


//Deleting from end of array 

//int[] newarray = new int [10];

//int length = 0;

//for(int i = 0; i < 6; i++)
//{
//    newarray[length] = i;
//    length++;
//}

//length--; 

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine(newarray[i]);
//}