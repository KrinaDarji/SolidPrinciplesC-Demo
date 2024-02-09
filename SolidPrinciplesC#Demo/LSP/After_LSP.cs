using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesC_Demo.LSP;

// Base class representing a shape
public abstract class Shape
{
    public abstract int CalculateArea();
}

// Rectangle class
public class Rectangle1 : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int CalculateArea()
    {
        return Width * Height;
    }
}

// Square class
public class Square1 : Shape
{
    public int SideLength { get; set; }

    public override int CalculateArea()
    {
        return SideLength * SideLength;
    }
}
