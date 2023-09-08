string [] arr = new string[]{"pickachu", "charmander", "squirtle"};
//O(n) - Linear - Loop
string findSquirtle(string []arr){
  int count = 0;
  for(int = 0 ; i < arr.Length; i++)
  {
    if(arr[i] == "squirtle")
    {
      return "Found squirtle";
    }
    return "No squirtle";
  }
}

string [] arr = new string[]{"pickachu", "charmander", "squirtle"};
//O(n ^ 2) - Quadratic - Loop inside a loop - "Brute Force"
string printLetters(string[]arr)
{
  for(int i = 0; i < 10; i++)
  {
    for(int j = 0; j < 10; j++)
    {
      System.Console.Writeline(arry[i][j]);
    }
  }
  return "No squirtle";
}
