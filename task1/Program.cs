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

    // Updated the method parameter type to Trapeze
    public static void PrintTrapeze(Trapeze trapeze)
    {
        trapeze.DisplayLengths();

        double roundedPerimeter = Math.Round(trapeze.CalculatePerimeter(), 2);

        Console.WriteLine($"Perimeter: {roundedPerimeter}");
        Console.WriteLine($"Area: {trapeze.CalculateArea()}");
        Console.WriteLine($"Is Square: {trapeze.IsSquare}");
        Console.WriteLine($"Color: {trapeze.Color}");
        Console.WriteLine();
    }

    // Updated the method parameter type to Trapeze[]
    public static void PrintAllTrapezes(Trapeze[] trapezes)
    {
        foreach (var trapeze in trapezes)
        {
            PrintTrapeze(trapeze);
        }
    }
}

class Program
{
    static void Main()
    {
        // Corrected the array initialization
        Trapeze[] trapezes = new Trapeze[]
        {
            new Trapeze(5, 8, 4, "red"),
            new Trapeze(6, 6, 3, "blue"),
            new Trapeze(15, 9, 7, "green")
        };

        Trapeze.PrintAllTrapezes(trapezes);
    }
}