using System;

[SoftUni("Peter")]
public class StartUp
{
    [SoftUni("Antonia")]
    public static void Main()
    {
        Tracker tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
    }
}