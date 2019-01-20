namespace Google
{
    using System;

    public class Parent
    {
        public string Name { get; set; }

        public string Birthday { get; set; }

        public Parent(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public override string ToString()
        {
            string output = string.Empty;

            output = string.Concat(output, $"{Name} {Birthday}");

            return output;
        }
    }
}
