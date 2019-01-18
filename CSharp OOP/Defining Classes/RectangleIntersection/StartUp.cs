namespace RectangleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] loops = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < loops[0]; i++)
            {
                string[] info = Console.ReadLine().Split();

                rectangles.Add(new Rectangle(info[0], double.Parse(info[1]), double.Parse(info[2]), double.Parse(info[3]), double.Parse(info[4])));
            }

            for (int i = 0; i < loops[1]; i++)
            {
                string[] info = Console.ReadLine().Split();

                Rectangle rectangleOne = rectangles.Find(x => x.Id == info[0]);
                Rectangle rectangleTwo = rectangles.Find(x => x.Id == info[1]);

                if (rectangleOne.DoRectanglesIntersect(rectangleTwo))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
