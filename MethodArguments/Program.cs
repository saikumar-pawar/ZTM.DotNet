//value types

Rectangle rectangle = new Rectangle(600, 400);
Console.WriteLine($"rectangle height: {rectangle.Height}");

MethodParameters.ChangeHeight( rectangle );
Console.WriteLine($"rectangle height: {rectangle.Height}");

Rectangle rectangle2 = new Rectangle(1000, 400);
Console.WriteLine($"rectangle width: {rectangle2.Width}");

MethodParameters.ChangeWidth( ref rectangle2 );
Console.WriteLine($"rectangle width: {rectangle2.Width}");

//reference types

Person person = new Person("Rajesh");
Console.WriteLine($"Name: {person.Name}");

MethodParameters.ChangeName( person );
Console.WriteLine($"Name: {person.Name}");

Person person2 = new Person("Sam");
Console.WriteLine($"Name: {person2.Name}");

MethodParameters.ChangeNameByReference( ref person2 );
Console.WriteLine($"Name: {person2.Name}");

Person person3 = new Person("Sam");
Console.WriteLine($"Name: {person3.Name}");

MethodParameters.ChangeNameByReferenceActualWorking( ref person3 );
Console.WriteLine($"Name: {person3.Name}");

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

    public static void ChangeName(Person person)
    {
        person.Name = "Unknown";
    }

    public static void ChangeNameByReference(ref Person person)
    {
        person.Name = "Unknown";
    }

    public static void ChangeNameByReferenceActualWorking(ref Person person)
    {
        person.Name = "Unknown";
        person = new Person("Ramesh");
    }
}

public class Person
{
    public Person(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}
