
var rectangle = new Rectangle(200,300);
Console.WriteLine($"rectangle height: {rectangle.Height}");

MethodParameters.ChangeHeight( ref rectangle);
Console.WriteLine($"rectangle height: {rectangle.Height}");

public struct Rectangle
{
    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }
    public double Height { get; set; }
    public double Width { get; set; }
}

public class MethodParameters
{
    public static void ChangeHeight(ref Rectangle rectangle)
    {
        rectangle.Height = 500;
        Console.WriteLine($"rectangle height is {rectangle.Height}");
    }
}