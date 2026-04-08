using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler
{
    public class NormalType : PokeType
    {

        public NormalType(Elements weak, Elements strong) : base(weak, strong)
        {
            AttackList.Add("Scratch", new Move("Scratch", 6, Elements.Normal, MoveCategory.Physical, StatusType.Attack));
            AttackList.Add("Tackle", new Move("Tackle", 8, Elements.Normal, MoveCategory.Physical, StatusType.None));

            AttackList.Add("Growl", new Move("Growl", 4, Elements.Normal, MoveCategory.Physical, StatusType.Attack));
            AttackList.Add("Sand ", new Move("Tail Whip", 4, Elements.Normal, MoveCategory.Physical, StatusType.Defense));
            AttackList.Add("Leer", new Move("leer", 4, Elements.Normal, MoveCategory.Physical, StatusType.Defense));
            AttackList.Add("Howl", new Move("Howl", 4, Elements.Normal, MoveCategory.Physical, StatusType.Attack));
        }
    }
}
