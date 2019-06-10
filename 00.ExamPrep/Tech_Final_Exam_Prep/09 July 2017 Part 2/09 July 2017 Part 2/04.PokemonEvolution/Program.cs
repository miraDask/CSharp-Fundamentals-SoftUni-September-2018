namespace _04.PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Type
    {
        public Type(string name, int index)
        {
            Name = name;
            Index = index;
        }

        public string Name { get; set; }

        public int Index { get; set; }
    }

    public class Pokemon
    {
        public Pokemon(string name)
        {
            Name = name;
            Types = new List<Type>();

        }

        public string Name { get; set; }

        public List<Type> Types { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                string[] pokemonData = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string pokemonName = pokemonData[0];

                if (pokemonData.Length == 1)
                {
                    if (pokemons.Any(p => p.Name == pokemonName))
                    {
                        Pokemon pokemon = pokemons.Find(p => p.Name == pokemonName);

                        Console.WriteLine($"# {pokemon.Name}");

                        foreach (Type type in pokemon.Types)
                        {
                            Console.WriteLine($"{type.Name} <-> {type.Index}");
                        }
                    }
                }
                else
                {
                    string pokemonType = pokemonData[1];
                    int pokemonIndex = int.Parse(pokemonData[2]);

                    if (!pokemons.Any(p => p.Name == pokemonName))
                    {
                        Pokemon newPokemon = new Pokemon(pokemonName);
                        newPokemon.Types.Add(new Type(pokemonType, pokemonIndex));
                        pokemons.Add(newPokemon);

                    }
                    else
                    {
                        Pokemon newPokemon = pokemons.Find(p => p.Name == pokemonName);
                        newPokemon.Types.Add(new Type(pokemonType,pokemonIndex));
                    }
                }
            }

            foreach (Pokemon pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Name}");

                foreach (var type in pokemon.Types.OrderByDescending(p => p.Index))
                {
                    Console.WriteLine($"{type.Name} <-> {type.Index}");
                }
            }
        }
    }
}
