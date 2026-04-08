using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler
{
    public class GrassType : PokeType
    {   

        public GrassType(Elements weak, Elements strong) : base(weak, strong)
        {
            AttackList.Add("Vine Whip", new Move("Vine Whip",4,Elements.Grass, MoveCategory.Physical, StatusType.Attack));
            AttackList.Add("Razor Leaf", new Move("Razor Leaf", 6, Elements.Grass, MoveCategory.Special, StatusType.SpAtk));

            AttackList.Add("String Shot", new Move("String Shot", 4, Elements.Grass, MoveCategory.Status, StatusType.Speed));
        }
    }
}
