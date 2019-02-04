namespace PersonInfo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            IPerson person = new Citizen(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
