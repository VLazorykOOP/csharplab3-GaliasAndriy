using System;

class Trapeze
{
    private int a, b, h;
    private string color;

    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int B
    {
        get { return b; }
        set { b = value; }
    }

    public int H
    {
        get { return h; }
        set { h = value; }
    }

    public string Color
    {
        get { return color; }
    }

    public Trapeze(int a, int b, int h, string color)
    {
        this.a = a;
        this.b = b;
        this.h = h;
        this.color = color;
    }

    public void DisplayLengths()
    {
        Console.WriteLine($"Lengths: a = {a}, b = {b}, h = {h}");
    }

    public double CalculatePerimeter()
    {
        return a + b + 2 * Math.Sqrt(Math.Pow((b - a) / 2, 2) + h * h);
    }

    public double CalculateArea()
    {
        return 0.5 * (a + b) * h;
    }

    public bool IsSquare
    {
        get { return a == b; }
    }
}



class Program
{
    static void Main()
    {
        Trapeze trapeze1 = new Trapeze(5, 8, 4, "red");
        Trapeze trapeze2 = new Trapeze(6, 6, 3, "blue");

        trapeze1.DisplayLengths();
        Console.WriteLine($"Perimeter: {trapeze1.CalculatePerimeter()}");
        Console.WriteLine($"Area: {trapeze1.CalculateArea()}");
        Console.WriteLine($"Is Square: {trapeze1.IsSquare}");
        Console.WriteLine($"Color: {trapeze1.Color}");

        Console.WriteLine();

        trapeze2.DisplayLengths();
        Console.WriteLine($"Perimeter: {trapeze2.CalculatePerimeter()}");
        Console.WriteLine($"Area: {trapeze2.CalculateArea()}");
        Console.WriteLine($"Is Square: {trapeze2.IsSquare}");
        Console.WriteLine($"Color: {trapeze2.Color}");

    }
}