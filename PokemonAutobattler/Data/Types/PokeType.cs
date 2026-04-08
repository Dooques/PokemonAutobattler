using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler
{
    public abstract class PokeType
    {
        public Elements StrongAgainst;
        public Elements WeakAgainst;
        public Dictionary<string, Move> AttackList;

        public PokeType(Elements weak, Elements strong) 
        { 
            StrongAgainst = strong;
            WeakAgainst = weak;
            AttackList = new Dictionary<string, Move>();
        }
    }
}
