namespace SoftUniParking
{
    using System;
    using PokemonTrainer;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<Pokemon>> trainers = new();
            List<Trainer> TrainersInstance = new();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] cmdArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Pokemon pokemon = new Pokemon(cmdArgs[1], cmdArgs[2], int.Parse(cmdArgs[3]));
                //{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}
                if (!trainers.ContainsKey(cmdArgs[0]))
                {
                    trainers[cmdArgs[0]] = new List<Pokemon>();
                }
                trainers[cmdArgs[0]].Add(pokemon);
            }
            foreach (var item in trainers)
            {
                Trainer trainer = new Trainer(item.Key, item.Value);
                TrainersInstance.Add(trainer);
            }

            string inputElements = string.Empty;
            while ((inputElements = Console.ReadLine()) != "End")
            {
                string currElement = inputElements;
                foreach (var trainer in TrainersInstance)
                {
                    if (trainer.Pokemon.Any(x => x.Element == currElement))
                    {
                        trainer.IncreaseBadges();
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemon.Count; i++)
                        {
                            trainer.Pokemon[i].HealtReduction();
                            if (trainer.Pokemon[i].Health <= 0)
                            {
                                trainer.Pokemon.Remove(trainer.Pokemon[i]);
                                i--;
                            }
                        }
                    }
                }
            }

            foreach (var trainer in TrainersInstance.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemon.Count}");
            }
        }
    }
}
