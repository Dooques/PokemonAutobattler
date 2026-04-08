using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler
{
    public class FireType : PokeType
    {   

        public FireType(Elements weak = Elements.Water, Elements strong = Elements.Grass) : base(weak, strong)
        {
            AttackList.Add("Ember", new Move("Ember",4, Elements.Fire, MoveCategory.Special, StatusType.SpAtk));
            AttackList.Add("Fire Spin", new Move("Fire Spin", 6, Elements.Fire, MoveCategory.Special, StatusType.SpAtk));
        }
    }
}
