namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;

    public class Trainer
    {
        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }
    }
}
