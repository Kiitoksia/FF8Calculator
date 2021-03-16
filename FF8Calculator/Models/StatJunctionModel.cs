using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class StatJunctionModel : BaseModel
    {
        public StatJunctionModel(string name, int hp, decimal strength, decimal vitality, decimal magic, decimal spirit, decimal speed, decimal evasion, decimal hit, decimal luck)
        {
            Name = name;
            HP = hp;
            Strength = strength;
            Vitality = vitality;
            Magic = magic;
            Spirit = spirit;
            Speed = speed;
            Evasion = evasion;
            Hit = hit;
            Luck = luck;
        }

        public string Name { get; }
        public int HP { get; }
        public decimal Strength { get; }
        public decimal Vitality { get; }
        public decimal Magic { get; }
        public decimal Spirit { get; }
        public decimal Speed { get; }
        public decimal Evasion { get; }
        public decimal Hit { get; }
        public decimal Luck { get; }
    }
}
