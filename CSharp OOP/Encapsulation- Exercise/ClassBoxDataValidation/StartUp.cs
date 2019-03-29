namespace ClassBoxDataValidation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                Box box = new Box(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                box.PrintBox();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
