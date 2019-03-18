namespace BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);
            var instance = Activator.CreateInstance(type, true);

            while (true)
            {
                string[] command = Console.ReadLine().Split('_');

                if (command[0] == "END")
                {
                    break;
                }

                type.GetMethod(command[0], BindingFlags.NonPublic | BindingFlags.Instance)
                    .Invoke(instance, new object[] { int.Parse(command[1]) });

                Console.WriteLine(type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance)
                    .GetValue(instance));
            }
        }
    }
}
