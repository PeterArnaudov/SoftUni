using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points
{
    public class Program
    {
        public static void Main()
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestPoints(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }

        static Point[] ReadPoints()
        {
            int number = int.Parse(Console.ReadLine());

            Point[] points = new Point[number];
            for (int i = 0; i < number; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static Point[] FindClosestPoints(Point[] points)
        {
            double closest = double.MaxValue;
            Point[] closestPoints = new Point[2];

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = CalculateDistance(points[i], points[j]);

                    if (closest > distance)
                    {
                        closest = distance;
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }

            return closestPoints;
        }

        static void PrintDistance(Point[] points)
        {
            double distance = CalculateDistance(points[0], points[1]);
            Console.WriteLine($"{distance:f3}");
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
