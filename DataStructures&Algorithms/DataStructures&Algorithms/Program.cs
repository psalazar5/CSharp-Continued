//using DataStructures_Algorithms.ADT;
//using System.Collections;

//Stack ts = new Stack();
//Pokemon squirtle = new Pokemon(); // declaring data struct. a specific pokemon , abstraction / concrete implementation bc its repsentative of all pokemon

//Arrays 
//Array Insertions & Deletions 

//Inserting at the end of an array 
int[] newArray = new int[6];

//Make a var to keep the length b/c .Length is based off capacity and does not track actual index.
int length = 0;

//This adds data for us
for (int i = 0; i < 3; i++)
{
    //1 is optional 
    newArray[length] = i;
    length++;
}

newArray[length] = 8;
length++;