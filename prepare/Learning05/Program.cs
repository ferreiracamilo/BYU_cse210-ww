using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> listShapes = new List<Shape>();
        Square mySquare = new Square(3,"red");
        Rectangle myRectangle = new Rectangle(3,2,"blue");
        Circle myCircle = new Circle(2,"purple");
        listShapes.Add(mySquare);
        listShapes.Add(myRectangle);
        listShapes.Add(myCircle);

        foreach(Shape s in listShapes){
            Console.WriteLine($"The {s.GetColor()} {s.GetType()} area equals to {s.GetArea()}");
            Console.WriteLine();
        }

    }
}