 namespace HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type type = typeof(HarvestingFields);

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "HARVEST")
            {
                FieldInfo[] fields = null;

                if (command == "private")
                {
                    fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.IsPrivate).ToArray();
                }
                else if (command == "protected")
                {
                    fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Where(f => f.IsFamily).ToArray();
                }
                else if (command == "public")
                {
                    fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
                }
                else if (command == "all")
                {
                    fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
                }

                foreach (var field in fields)
                {
                    string accessModifier = field.IsPublic ? "public" : field.IsPrivate ? "private" : "protected";
                    Console.WriteLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}
