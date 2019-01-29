namespace ClassBoxDataValidation
{
    using System;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Heigth = height;
        }

        public double Length
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                length = value;
            }
        }

        public double Width
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }

        public double Heigth
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value;
            }
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
