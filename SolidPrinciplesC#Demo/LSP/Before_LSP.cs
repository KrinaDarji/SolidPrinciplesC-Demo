namespace SolidPrinciplesC_Demo.LSP;

// Base class representing a rectangle
public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int CalculateArea()
    {
        return Width * Height;
    }
}

// Derived class representing a square
public class Square : Rectangle
{
    public new int Width
    {
        set { base.Width = base.Height = value; }
    }

    public new int Height
    {
        set { base.Width = base.Height = value; }
    }
}