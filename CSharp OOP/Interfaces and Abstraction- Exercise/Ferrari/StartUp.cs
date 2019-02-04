namespace Ferrari
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            IFerrari ferrari = new Ferrari(Console.ReadLine());
            Console.WriteLine(ferrari);
        }
    }
}
