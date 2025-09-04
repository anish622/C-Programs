using System;

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

// Circle subclass
class Circle : Shape
{
    private double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

// Triangle subclass
class Triangle : Shape
{
    private double A,B,C;

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public override double CalculatePerimeter()
    {
        return A + B + C;
    }

    public override double CalculateArea()
    {
        double s = (A+B+C)/ 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C)); // Heron's formula
    }
}

class Program
{
    static void Main()
    {
        // Circle example
        Console.Write("Enter radius of circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle ci = new Circle(radius);
        Console.WriteLine("Circle Area:" + ci.CalculateArea());
        Console.WriteLine("Circle Perimeter:" + ci.CalculatePerimeter()); ;

        // Triangle example
        Console.Write("\nEnter sides of triangle (a b c): ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());
         Triangle t = new Triangle(a,b,c);
        Console.WriteLine("Triangle Area:"+t.CalculateArea());
        Console.WriteLine("Triangle Perimeter:" + t.CalculatePerimeter());
    }
}

