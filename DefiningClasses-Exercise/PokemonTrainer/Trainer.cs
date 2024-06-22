using System;
namespace PokemonTrainer
{
	public class Trainer
	{
        public Trainer(string name, List<Pokemon> pokemon)
        {
            Name = name;
            NumberOfBadges = 0;
            Pokemon = pokemon;
        }

        public string Name { get; set; }
		public int NumberOfBadges { get; set; }
		public List<Pokemon> Pokemon { get; set; }

        public void IncreaseBadges()
        {
            NumberOfBadges++;
        }
    }
}

