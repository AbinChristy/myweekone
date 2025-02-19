using System;
using Week1ObjectOriented.Classes;
using Week1ObjectOriented.Interfaces;

class Program
{
    static void Main()
    {//Just Keeping the code for exception handling
        Console.Write("Just to handle the Exception");

        Console.WriteLine();


        var square = new Square(5);

        try
        {
            square.SetSide(2);
            Console.WriteLine("The area of square is " + square.GetArea());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        ShapeColourHelper.AssignRandomColour(square);
        Console.WriteLine($"Square Colour: {square.Colour}");
        Console.WriteLine();

        //Random colours
        Shape[] shapes = new Shape[]
        {
            new Square(4),
            new Circle(5),
            new Triangle(6, 8),
            new Square(7),
            new Circle(2)
        };
        Console.WriteLine();
        Console.Write("Week 1 Assignment");

        Console.WriteLine();
        foreach (var shape in shapes)
        {
            ShapeColourHelper.AssignRandomColour(shape); 
            Console.WriteLine($"Shape: {shape.GetType().Name}, Area: {shape.GetArea()}, Colour: {shape.Colour}");
            if (shape is IFaces faceShape)
            {
                Console.Write($"Faces: {faceShape.GetFaces()}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
