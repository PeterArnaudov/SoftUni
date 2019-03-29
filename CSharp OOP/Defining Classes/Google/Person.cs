namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name { get; set; }

        public Company Company { get; set; }

        public Car Car { get; set; }

        public List<Parent> Parents { get; set; }

        public List<Child> Children { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Person(string name)
        {
            Name = name;
            Parents = new List<Parent>();
            Children = new List<Child>();
            Pokemons = new List<Pokemon>();
        }

        public override string ToString()
        {
            string output = string.Empty;

            output = string.Concat(output, Name);
            output = string.Concat(output, Environment.NewLine);
            output = string.Concat(output, "Company:");
            output = string.Concat(output, Environment.NewLine);

            if (Company != null)
            {
                output = string.Concat(output, Company.ToString());
                output = string.Concat(output, Environment.NewLine);
            }

            output = string.Concat(output, "Car:");
            output = string.Concat(output, Environment.NewLine);

            if (Car != null)
            {
                output = string.Concat(output, Car.ToString());
                output = string.Concat(output, Environment.NewLine);
            }

            output = string.Concat(output, "Pokemon:");
            output = string.Concat(output, Environment.NewLine);

            if (Pokemons.Any())
            {
                foreach (var pokemon in Pokemons)
                {
                    output = string.Concat(output, pokemon.ToString());
                    output = string.Concat(output, Environment.NewLine);
                }
            }

            output = string.Concat(output, "Parents:");
            output = string.Concat(output, Environment.NewLine);

            if (Parents.Any())
            {
                foreach (var parent in Parents)
                {
                    output = string.Concat(output, parent.ToString());
                    output = string.Concat(output, Environment.NewLine);
                }
            }

            output = string.Concat(output, "Children:");
            output = string.Concat(output, Environment.NewLine);

            if (Children.Any())
            {
                foreach (var child in Children)
                {
                    output = string.Concat(output, child.ToString());
                    output = string.Concat(output, Environment.NewLine);
                }
            }

            return output;
        }
    }
}
