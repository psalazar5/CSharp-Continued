var person = new Person("Pablo Salazar");
Console.WriteLine($"Name: {person.Name}");

MethodParameters.ChangeName(person);
Console.WriteLine($"Name: {person.Name}");
public class Person
{
    public Person(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}

public struct Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

}

public class MethodParameters
{
    public static void ChangeName(Person person)
    {
        person.Name = "Unknown";
    }

    public static void ChangeHeight(Rectangle rectangle1)
    {
        rectangle1.Height = 500;
        Console.WriteLine($"rectangle1 height is {rectangle1.Height}");
    }
}
