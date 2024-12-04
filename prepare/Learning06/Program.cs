using System;

class Program
{
    static void Main(string[] args)
    {
        // Test individual classes
        Square square = new Square("Red", 4);
        Console.WriteLine($"Square Color: {square.GetColor()}");
        Console.WriteLine($"Square Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 5, 7);
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle Color: {circle.GetColor()}");
        Console.WriteLine($"Circle Area: {circle.GetArea()}");

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>
        {
            new Square("Yellow", 6),
            new Rectangle("Purple", 4, 8),
            new Circle("Orange", 5)
        };

        // Iterate through the list and display details
        Console.WriteLine("\nShapes in the list:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}