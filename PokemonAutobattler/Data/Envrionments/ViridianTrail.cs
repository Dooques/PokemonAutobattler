using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler.Data.Envrionments
{
    public class ViridianTrail : Environment
    {
        public ViridianTrail(string name, (Elements, Elements) environmentTypes, int trainers, int events) :
                base(name, environmentTypes, trainers, events) { }

        public override void TrainerBattle() { }
        public override void PokemonBattle() { }
        public override void FindItem() { }
    }
}
