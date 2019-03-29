namespace Shapes
{
    using System;
    using Shapes;

    public class StartUp
    {
        public static void Main()
        {
            IDrawable circle = new Circle(int.Parse(Console.ReadLine()));
            IDrawable rectangle = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            circle.Draw();
            rectangle.Draw();
        }
    }
}
