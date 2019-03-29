namespace RectangleIntersection
{
    using System;

    public class Rectangle
    {
        public string Id { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public Rectangle(string id, double width, double height, double x, double y)
        {
            Id = id;
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }

        public bool DoRectanglesIntersect(Rectangle rectangle)
        {
            return rectangle.X + rectangle.Width >= this.X &&
                rectangle.Y - rectangle.Height <= this.Y &&
                rectangle.X <= this.X + this.Width &&
                rectangle.Y >= this.Y - this.Height;
        }
    }
}
