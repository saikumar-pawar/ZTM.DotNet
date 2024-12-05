Rectangle rectangle = new Rectangle(600, 400);
Console.WriteLine($"rectangle height: {rectangle.Height}");

MethodParameters.ChangeHeight( rectangle );
Console.WriteLine($"rectangle height: {rectangle.Height}");

Rectangle rectangle2 = new Rectangle(1000, 400);
Console.WriteLine($"rectangle width: {rectangle2.Width}");

MethodParameters.ChangeWidth( ref rectangle2 );
Console.WriteLine($"rectangle width: {rectangle2.Width}");

public struct Rectangle
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double Width { get; set; }
    public double Height { get; set; }
}

public class MethodParameters
{
    public static void ChangeHeight(Rectangle rectangle)
    {
        rectangle.Height = 500;
        Console.WriteLine($"rectangle height in method: {rectangle.Height}");
    }

    public static void ChangeWidth(ref Rectangle rectangle)
    {
        rectangle.Width = 1200;
        Console.WriteLine($"rectangle width in method: {rectangle.Width}");
    }
}