using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Trainer> trainerNameTrainer = new Dictionary<string, Trainer>();
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputTokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Pokemon pokemon = new Pokemon(inputTokens[1], inputTokens[2], int.Parse(inputTokens[3]));
                if (!trainerNameTrainer.ContainsKey(inputTokens[0]))
                {
                    Trainer trainer = new Trainer(inputTokens[0]);
                    trainer.Pokemons.Add(pokemon);
                    trainerNameTrainer.Add(trainer.Name, trainer);
                }
                else
                {
                    trainerNameTrainer[inputTokens[0]].Pokemons.Add(pokemon);
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainerNameTrainer)
                {
                    if (trainer.Value.Pokemons.Any(p => p.Element == input))
                    {
                        trainer.Value.BadgesCount++;
                    }
                    else
                    {
                        trainer.Value.Pokemons.ForEach(p => p.Health -= 10);
                        if (trainer.Value.Pokemons.Any(p => p.Health <= 0))
                        {
                            trainer.Value.Pokemons.RemoveAll(p => p.Health <= 0);
                        }
                    }
                }
            }

            foreach (var trainer in trainerNameTrainer.OrderByDescending(p => p.Value.BadgesCount))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.BadgesCount} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}