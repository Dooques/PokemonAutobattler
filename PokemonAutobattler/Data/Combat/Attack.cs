using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler
{
    public class Move
    {
        public string Name;
        public int Damage;
        public Elements Type;
        public MoveCategory Category;
        public StatusType Status;

        public Move(string name, int damage, Elements type, MoveCategory moveCategory, StatusType status)
        {
            Name = name;
            Damage = damage;
            Type = type;
            Category = moveCategory;
            Status = status;
        } 
    }
}
