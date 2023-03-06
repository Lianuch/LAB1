using System;

class Circle
{
    public float radius;
    public float square;
    public float length;
    public float pi = 3.14f;

    public void SetRadius(float Radius)
    {
        radius = Radius;
        Console.WriteLine("Radius:" + radius);
    }

    public float GetRadius()
    {
        return radius;
    }

    public float GetLength()
    {
        length = 2 * pi * radius;
        return length;
    }

    public float GetSquare()
    {
        square = pi * (radius * radius);
        return square;
    }

    public void Check()
    {
        try
        {
            if (radius >= 0 && radius <= 12)
            {
                throw new Exception();
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error! It's not possible.");
        }
    }

    public void Print()
    {
        Console.WriteLine("\nLength:" + length + "\nSquare:" + square);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
       // Console.ForegroundColor = ConsoleColor.White;

        Circle show = new Circle();
        show.SetRadius(11.99f);
        show.GetRadius();

        show.GetLength();
        show.GetSquare();

        show.Print();
        show.Check();

        Console.ResetColor();

        Console.ReadKey();
    }
}