using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class StatModel : BaseModel
    {
        public StatModel(int level, int hp, int strength, int vitality, int magic, int spirit, int speed, int luck)
        {
            Level = level;
            HP = hp;
            Strength = strength;
            Vitality = vitality;
            Magic = magic;
            Spirit = spirit;
            Speed = speed;
            Luck = luck;
        }

        public int Level { get; }
        public int HP { get; }
        public int Strength { get; }
        public int Vitality { get; }
        public int Magic { get; }
        public int Spirit { get; }
        public int Speed { get; }
        public int Luck { get; }
    }
}
