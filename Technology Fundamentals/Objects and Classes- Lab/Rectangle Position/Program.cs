using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Position
{
    public class Program
    {
        public static void Main()
        {
            Rectangle rectangleOne = ReadRectangle();
            Rectangle rectangleTwo = ReadRectangle();

            bool inside = rectangleOne.IsInside(rectangleTwo);

            string result = inside ? "Inside" : "Not inside";

            Console.WriteLine(result);
        }

        public class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Right { get { return Left + Width; } }
            public int Bottom { get { return Top + Height; } }

            public bool IsInside(Rectangle other)
            {
                bool isInLeft = Left >= other.Left;
                bool isInRight = Right <= other.Right;
                bool isInsideHorizontal = isInLeft && isInRight;

                bool isInTop = Top >= other.Top;
                bool isInBottom = Bottom <= other.Bottom;
                bool isInsideVertical = isInTop && isInBottom;

                return isInsideHorizontal && isInsideVertical;
            }
        }

        public static Rectangle ReadRectangle()
        {
            int[] rectanglePoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            return new Rectangle
            {
                Left = rectanglePoints[0],
                Top = rectanglePoints[1],
                Width = rectanglePoints[2],
                Height = rectanglePoints[3]
            };
        }
    }
}