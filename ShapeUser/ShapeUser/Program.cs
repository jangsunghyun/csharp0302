using System;
using Shapes;

namespace ShapeUser
{
    public class ShapeUser
    {
        static void Main()
        {
            Circle c = new Circle(1.0F);
            Console.WriteLine("Area of Circle(1.0) is {0}", c.Area());
        }
    }
}
