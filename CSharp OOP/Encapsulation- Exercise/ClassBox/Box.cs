namespace ClassBox
{
    using System;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetSurfaceArea()
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public double GetLateralSurfaceArea()
        {
            return 2 * length * height + 2 * width * height;
        }

        public double GetVolume()
        {
            return length * width * height;
        }

        public void PrintBox()
        {
            Console.WriteLine($"Surface Area - {GetSurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {GetLateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {GetVolume():f2}");
        }
    }
}
