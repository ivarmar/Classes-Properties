using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Properties
{
    internal class CreatePokemon
    {
        public List<string> pokedex = new List<string>();


        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public string ShowPokemon()
        {
            var pokemon = $"Pokemon name:{Name}\nPokemon HP: {Health}\nPokemon level: {Level}\n";
            Console.Write(pokemon);
            return pokemon;
        }


        public string SetPokemonName(string name)
        {
            Name = name;
            return Name;
        }

        public int SetPokemonHealth()
        {
            Health = GenerateRandom(10, 20);
            return Health;
        }

        public int SetPokemonLevel()
        {
            Level = GenerateRandom(1, 5);
            return Level;
        }

        public int GenerateRandom(int min, int max)
        {
            var Generatedrandom = new Random();
            var random = Generatedrandom.Next(min, max);
            
            return random;
        }

        public CreatePokemon()
        {
            Console.WriteLine("Set your pokemons name:");

            SetPokemonName(Console.ReadLine()??"");
            SetPokemonHealth();
            SetPokemonLevel();

            Console.WriteLine($"Finalized results:");
            
            pokedex.Add(ShowPokemon());
        }
    }
}

