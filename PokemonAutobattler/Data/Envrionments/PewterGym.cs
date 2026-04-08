using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler
{
    public class PewterGym : Environment
    {
        public PewterGym(string name, (Elements, Elements) environmentTypes, int trainers, int events) :
                base(name, environmentTypes, trainers, events) {  }
        public override void TrainerBattle() { }
        public override void PokemonBattle() { }
        public override void FindItem() { }
    }
}
