using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler
{
    public class WaterType : PokeType
    {   

        public WaterType(Elements weak, Elements strong) : base(weak, strong)
        {
            AttackList.Add("Bubble", new Move("Bubble", 4, Elements.Water, MoveCategory.Special, StatusType.SpAtk));
            AttackList.Add("Water Cannon", new Move("Water Cannon", 2, Elements.Water, MoveCategory.Special, StatusType.SpAtk));
        }
    }
}
