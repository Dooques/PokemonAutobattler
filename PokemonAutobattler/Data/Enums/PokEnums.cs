using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler
{
    public enum Elements
    {
        Normal, Fire, Water, Grass, Electric, Ice, Fighting, Poison,
        Ground, Flying, Psychic, Bug, Rock, Ghost, Dragon, Dark, Steel, Fairy
    }

    public enum MoveCategory
    {
        Physical, // Uses Attack vs Defense
        Special,  // Uses SpAtk vs SpDef
        Status    // No direct damage; effects only
    }

    public enum StatusType
    {
        Attack, Defense, SpAtk, SpDef, Speed, None
    }

    public enum Evolution
    {
        StageOne, StageTwo, StageThree
    }
}
