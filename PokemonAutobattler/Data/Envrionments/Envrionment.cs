using PokemonAutoBattler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler
{
    public abstract class Environment
    {
        public string Name { get; private set; }
        public List<Pokemon> Catchable { get; private set; }
        public int Trainers { get; private set; }
        public int Events { get; private set; }

        public Environment(string name, (Elements, Elements) areaTypes, int trainers, int events)
        {
            Name = name;
            Catchable = Pokedex.GetPokemon().Where(p => p.Type1.Equals(areaTypes.Item1)).Select( p => p).ToList();
            Trainers = trainers;
            Events = events;
        }

        public abstract void TrainerBattle();
        public abstract void PokemonBattle();
        public abstract void FindItem();
    }
}
