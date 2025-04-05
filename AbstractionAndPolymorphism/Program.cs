using System;

class Program
{
    public static void Main()
    {   
        Console.Write("Shape Calculator\n");
        Console.Write("[1] Square\n");
        Console.Write("[2] Rectangle\n");
        Console.Write("[3] Triangle\n");
        Console.Write("[4] Circle\n");
        Console.Write("Enter your Choice: ");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.Write("Enter side: ");
                int inputSide = int.Parse(Console.ReadLine());
                Square square = new Square(inputSide);
                Console.WriteLine($"Area: {square.Area}\nPerimeter: {square.Perimeter}");
                break;
            case 2:
                Console.Write("Enter length: ");
                float length = float.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                float width = float.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(length, width);
                Console.WriteLine($"Area: {rectangle.Area}\nPerimeter: {rectangle.Perimeter}");
                break;
            case 3:
                Console.Write("Enter base: ");
                float baseSide = float.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                float height = float.Parse(Console.ReadLine());
                Console.Write("Enter side 1: ");
                float side1 = float.Parse(Console.ReadLine());
                Console.Write("Enter side 2: ");
                float side2 = float.Parse(Console.ReadLine());
                Console.Write("Enter side 3: ");
                float side3 = float.Parse(Console.ReadLine());
                Triangle triangle = new Triangle(baseSide, height, side1, side2, side3);
                Console.WriteLine($"Area: {triangle.Area}\nPerimeter: {triangle.Perimeter}");
                break;
            case 4:
                Console.Write("Enter radius: ");
                float radius = float.Parse(Console.ReadLine());
                Circle circle = new Circle(radius);
                Console.WriteLine($"Area: {circle.Area}\nPerimeter: {circle.Perimeter}");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}

public abstract class Shape
{
    public abstract float Area { get; }
    public abstract float Perimeter { get; }
}

public class Square : Shape
{
    public Square(float side)
    {
        this.Side = side;
    }

    public float Side { get; set; }     

    public override float Area 
    { 
        get { return Side * Side; } 
    }
    
    public override float Perimeter 
    { 
        get { return 4 * Side; } 
    }
}

public class Triangle : Shape
{
    public Triangle(float baseSide, float height, float side1, float side2, float side3)
    {
        this.BaseSide = baseSide;
        this.Height = height;
        this.Side1 = side1;
        this.Side2 = side2;
        this.Side3 = side3;
    }

    public float BaseSide { get; set; }
    public float Height { get; set; }
    public float Side1 { get; set; }
    public float Side2 { get; set; }
    public float Side3 { get; set; }

    public override float Area 
    { 
        get { return 0.5f * BaseSide * Height; } 
    }

    public override float Perimeter 
    { 
        get { return Side1 + Side2 + Side3; } 
    }
}

public class Rectangle : Shape
{
    public Rectangle(float length, float width)
    {
        this.Length = length;
        this.Width = width;
    }

    public float Length { get; set; }
    public float Width { get; set; }

    public override float Area 
    { 
        get { return Length * Width; } 
    }

    public override float Perimeter 
    { 
        get { return 2 * (Length + Width); } 
    }
}

public class Circle : Shape
{
    public Circle(float radius)
    {
        this.Radius = radius;
    }

    public float Radius { get; set; }

    public override float Area 
    { 
        get { return (float)(Math.PI * Radius * Radius); } 
    }

    public override float Perimeter 
    { 
        get { return (float)(2 * Math.PI * Radius); } 
    }
}