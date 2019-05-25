using System;
namespace MethodOverriding
{
    public class Circle:Shape
    {
        public override void Draw()
        {
            //Any code specific to circle class
            Console.WriteLine("Draw a circle.");
        }
    }

    public class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }

    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle.");
        }
    }
}
