using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Shape (polymorphic collection)
        List<Shape> shapes = new List<Shape>();

        // Add various shapes to the list
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // Iterate through the shapes and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea():0.00}");
        }
    }
}
