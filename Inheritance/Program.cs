using System;

class Shapes
{
    public float Area() { return 0; }
    public float Perimeter() { return 0; }
}

class Circle : Shapes
{
    public Circle()
    {
    }

    public Circle(float radius)
    {
        this.radius = radius;
    }

    private float radius;

    public float Radius
    {
        get { return this.radius; }
        set { this.radius = value; }
    }

    public float Area()
    {
        return (float)(Math.PI * Math.Pow(this.radius, 2));
    }

    public float Perimeter()
    {
        return (float)(2 * Math.PI * this.radius);
    }
}

class Rectangle : Shapes
{
    public Rectangle()
    {
    }

    public Rectangle(float length, float width)
    {
        this.length = length;
        this.width = width;
    }

    private float length;
    private float width;

    public float Length
    {
        get { return this.length; }
        set { this.length = value; }
    }

    public float Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public float Area()
    {
        return this.length * this.width;
    }

    public float Perimeter()
    {
        return 2 * (this.length + this.width);
    }
}

class Triangle : Shapes
{
    public Triangle()
    {
    }

    public Triangle(float bases, float sideA, float sideB, float height)
    {
        this.bases = bases;
        this.sideA = sideA;
        this.sideB = sideB;
        this.height = height;
    }

    private float bases;
    private float sideA;
    private float sideB;
    private float height;

    public float Bases
    {
        get { return this.bases; }
        set { this.bases = value; }
    }

    public float SideA
    {
        get { return this.sideA; }
        set { this.sideA = value; }
    }

    public float SideB
    {
        get { return this.sideB; }
        set { this.sideB = value; }
    }

    public float Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public float Area()
    {
        return this.bases * this.height / 2;
    }

    public float Perimeter()
    {
        return this.bases + this.sideA + this.sideB;
    }
}

class Square : Shapes
{
    public Square()
    {
    }

    public Square(float side)
    {
        this.side = side;
    }

    private float side;

    public float Side
    {
        get { return this.side; }
        set { this.side = value; }
    }

    public float Area()
    {
        return (float)Math.Pow(this.side, 2);
    }

    public float Perimeter()
    {
        return 4 * this.side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Triangle triangle = new Triangle();
        Square square = new Square();

        Console.WriteLine("What Shape?");
        Console.WriteLine("[1] Circle\n[2] Rectangle\n[3] Triangle\n[4] Square");

        int choiceShape = int.Parse(Console.ReadLine());
        switch (choiceShape)
        {
            case 1:
                Console.Write("Enter Radius: ");
                circle.Radius = float.Parse(Console.ReadLine());
                Console.WriteLine($"Circle Area: {circle.Area()}");
                Console.WriteLine($"Circle Perimeter: {circle.Perimeter()}");
                break;

            case 2:
                Console.Write("Enter Length: ");
                rectangle.Length = float.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                rectangle.Width = float.Parse(Console.ReadLine());
                Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
                Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter()}");
                break;

            case 3:
                Console.Write("Enter Base: ");
                triangle.Bases = float.Parse(Console.ReadLine());
                Console.Write("Enter Side A: ");
                triangle.SideA = float.Parse(Console.ReadLine());
                Console.Write("Enter Side B: ");
                triangle.SideB = float.Parse(Console.ReadLine());
                Console.Write("Enter Height: ");
                triangle.Height = float.Parse(Console.ReadLine());
                Console.WriteLine($"Triangle Area: {triangle.Area()}");
                Console.WriteLine($"Triangle Perimeter: {triangle.Perimeter()}");
                break;

            case 4:
                Console.Write("Enter Side: ");
                square.Side = float.Parse(Console.ReadLine());
                Console.WriteLine($"Square Area: {square.Area()}");
                Console.WriteLine($"Square Perimeter: {square.Perimeter()}");
                break;

            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}