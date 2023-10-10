//int? age = null;

//if (age.HasValue)
//{
//    Console.WriteLine(age.Value);
//}
//else { Console.WriteLine("Age does not have a value."); }
//used for when needing to read data from a data base w/ a column that allows null as a value or for variables to indicate that a value has not been set 

//Nullable reference types 

var person1 = new Person("Jasmine");
Console.WriteLine(person1.Name);


Person? person2 = null;
if(person2 != null) { Console.WriteLine(person2.Name); }


Person? person3 = null;
Console.WriteLine(person3?.Name);
Console.WriteLine("The end ");

public class Person
{
    public Person(string firstName)
    {
        Name = firstName;
    }
    public string Name { get; set; }
}