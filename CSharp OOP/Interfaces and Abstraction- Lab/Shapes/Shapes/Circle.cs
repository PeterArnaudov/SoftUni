namespace Shapes.Shapes
{
    using System;

    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get => this.radius;

            private set => this.radius = value;
        }

        public void Draw()
        {
            double rIn = this.radius - 0.4;
            double rOut = this.radius + 0.4;

            for (double y = this.Radius; y >= -this.radius; y--)
            {
                for (double x = -this.radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
