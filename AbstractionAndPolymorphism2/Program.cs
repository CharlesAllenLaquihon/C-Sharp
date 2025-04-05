using System;

class Program
{
    public static void Main()
    {   
        Console.Write("3D Shape Calculator\n");
        Console.Write("[1] Cube\n");
        Console.Write("[2] Cuboid\n");
        Console.Write("[3] Cylinder\n");
        Console.Write("[4] Sphere\n");
        Console.Write("[5] Cone\n");
        Console.Write("Enter your Choice: ");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Console.Write("Enter side: ");
                float side = float.Parse(Console.ReadLine());
                Cube cube = new Cube(side);
                Console.WriteLine($"Surface Area: {cube.SurfaceArea}\nVolume: {cube.Volume}");
                break;
            case 2:
                Console.Write("Enter length: ");
                float length = float.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                float width = float.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                float height = float.Parse(Console.ReadLine());
                Cuboid cuboid = new Cuboid(length, width, height);
                Console.WriteLine($"Surface Area: {cuboid.SurfaceArea}\nVolume: {cuboid.Volume}");
                break;
            case 3:
                Console.Write("Enter radius: ");
                float radius = float.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                float cylinderHeight = float.Parse(Console.ReadLine());
                Cylinder cylinder = new Cylinder(radius, cylinderHeight);
                Console.WriteLine($"Surface Area: {cylinder.SurfaceArea}\nVolume: {cylinder.Volume}");
                break;
            case 4:
                Console.Write("Enter radius: ");
                float sphereRadius = float.Parse(Console.ReadLine());
                Sphere sphere = new Sphere(sphereRadius);
                Console.WriteLine($"Surface Area: {sphere.SurfaceArea}\nVolume: {sphere.Volume}");
                break;
            case 5:
                Console.Write("Enter radius: ");
                float coneRadius = float.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                float coneHeight = float.Parse(Console.ReadLine());
                Cone cone = new Cone(coneRadius, coneHeight);
                Console.WriteLine($"Surface Area: {cone.SurfaceArea}\nVolume: {cone.Volume}");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}

public abstract class Shape3D
{
    public abstract float SurfaceArea { get; }
    public abstract float Volume { get; }
}

public class Cube : Shape3D
{
    public Cube(float side)
    {
        this.Side = side;
    }
    public float Side { get; set; }
    public override float SurfaceArea { get { return 6 * Side * Side; } }
    public override float Volume { get { return Side * Side * Side; } }
}

public class Cuboid : Shape3D
{
    public Cuboid(float length, float width, float height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }
    public float Length { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public override float SurfaceArea { get { return 2 * (Length * Width + Width * Height + Height * Length); } }
    public override float Volume { get { return Length * Width * Height; } }
}

public class Cylinder : Shape3D
{
    public Cylinder(float radius, float height)
    {
        this.Radius = radius;
        this.Height = height;
    }
    public float Radius { get; set; }
    public float Height { get; set; }
    public override float SurfaceArea { get { return 2 * (float)Math.PI * Radius * (Radius + Height); } }
    public override float Volume { get { return (float)Math.PI * Radius * Radius * Height; } }
}

public class Sphere : Shape3D
{
    public Sphere(float radius)
    {
        this.Radius = radius;
    }
    public float Radius { get; set; }
    public override float SurfaceArea { get { return 4 * (float)Math.PI * Radius * Radius; } }
    public override float Volume { get { return (4f / 3f) * (float)Math.PI * Radius * Radius * Radius; } }
}

public class Cone : Shape3D
{
    public Cone(float radius, float height)
    {
        this.Radius = radius;
        this.Height = height;
    }
    public float Radius { get; set; }
    public float Height { get; set; }
    public override float SurfaceArea { get { return (float)Math.PI * Radius * (Radius + (float)Math.Sqrt(Height * Height + Radius * Radius)); } }
    public override float Volume { get { return (1f / 3f) * (float)Math.PI * Radius * Radius * Height; } }
}