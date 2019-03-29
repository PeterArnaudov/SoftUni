namespace Google
{
    using System;

    public class Pokemon
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public Pokemon(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override string ToString()
        {
            string output = string.Empty;

            output = string.Concat(output, $"{Name} {Type}");

            return output;
        }
    }
}
