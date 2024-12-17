using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square squ = new Square("Blue", 3.2);
        shapes.Add(squ);

        Rectangle rec = new Rectangle(6, 4.5, " Yellow");
        shapes.Add(rec);

        Circle cir = new Circle("Red", 5);
        shapes.Add(cir);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color: {color }, Area: { area}");
        } 
    }
}