namespace EventImplementation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    dispatcher.NameChange -= handler.OnDispatcherNameChange;
                    return;
                }

                dispatcher.Name = name;
            }
        }
    }
}
