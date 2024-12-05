Rectangle rectangle = new Rectangle(3, 9);
ImmutableRectangle immutableRectangle = new ImmutableRectangle(6, 12);
//immutableRectangle.Height = 8;

public struct Rectangle
{
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
    public double Height { get; set; }
    public double Width { get; set; }
}

public readonly struct ImmutableRectangle
{
    public ImmutableRectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
    public double Height { get; init; }
    public double Width { get; init; }
}