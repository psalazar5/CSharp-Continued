using PassingReference_TypeParameters;

var person = new Person("Pablo Salazar");
Console.WriteLine($"Name : {person.Name}");       

var rectangle = new Rectangle();          
Console.WriteLine($"rectangle height is {rectangle.Height}");

MethodParameters.ChangeName( person);
Console.WriteLine($"Name : {person.Name}");