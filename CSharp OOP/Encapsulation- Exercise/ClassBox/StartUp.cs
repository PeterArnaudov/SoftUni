namespace ClassBox
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Box box = new Box(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            box.PrintBox();
        }
    }
}
