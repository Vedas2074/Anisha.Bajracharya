using System;
public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public virtual void PrintDetails()
    {
        Console.WriteLine("Print details for shape...");
    }
    
}
public interface IDiagonalComputable
{
    public double GetDiagonalLength();
}

public class Rectangle : Shape, IDiagonalComputable
{
    public Rectangle(double l, double b)
    {
        this.Length = l;
        this.Breadth = b;
    }
    public double Length { get; set; }
    public double Breadth { get; set; }

    public override double GetArea() => Length * Breadth;

    public double GetDiagonalLength() => Math.Sqrt(Length*Length + Breadth*Breadth);
    
    public override double GetPerimeter() => 2 * (Length + Breadth); 

    public override void PrintDetails()
    {
        Console.WriteLine("Print details for Rectangle...");
        Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        Console.WriteLine($"Area: {this.GetArea()}, Perimeter: {this.GetPerimeter()}");

    }
    
}

public class Square : Rectangle
{
    // public double Side { get; set; }
    // public override double GetArea() => Side * Side;

    // public override double GetPerimeter() => 4 * Side; 

    public Square(double s) : base(s, s)
    {
    
    }
    
}

public class Circle : Shape
{
     public Circle(double r)
    {
        Radius = r;
    }
    
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;

    public override double GetPerimeter() => 2 * Math.PI * Radius; 
}
   
// multiple inheritance not allowed but can be used with interface