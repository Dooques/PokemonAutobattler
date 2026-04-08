using PokemonAutoBattler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAutoBattler
{
    public class Pokemon : IRollable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAtk { get; set; }
        public int SpDef { get; set; }
        public int Speed { get; set; }
        public Evolution Evolution { get; private set; }

        public Pokemon(int id, string name, Evolution evolution, string t1, string t2, int hp, int atk, int def, int spa, int spd, int spe)
        {
            Id = id; 
            Name = name; 
            Evolution = evolution;
            Type1 = t1; 
            Type2 = t2;
            HP = hp; 
            Attack = atk; 
            Defense = def;
            SpAtk = spa; 
            SpDef = spd; 
            Speed = spe;
        }

        public float Roll(float potency)
        {
            Random random = new Random();
            int rollResult = random.Next(0, 255);

            float finalValue = 1f;

            if (rollResult < 26) { finalValue = 0.5f * potency; } // 11.2%
            if (rollResult < 126) { finalValue = 0.7f * potency; } // 33.2%
            if (rollResult < 208) { finalValue = 0.8f * potency; } // 33.2%
            if (rollResult < 229) { finalValue = 0.9f * potency; } // 11.2%
            finalValue *= potency; // 11.2%

            return finalValue;
        }
    }
}
