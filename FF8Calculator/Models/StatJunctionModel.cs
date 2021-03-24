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

        public decimal GetStat(JunctionType type)
        {
            switch (type)
            {
                case JunctionType.HP: return HP;
                case JunctionType.STR: return Strength;
                case JunctionType.VIT: return Vitality;
                case JunctionType.MAG: return Magic;
                case JunctionType.SPR: return Spirit;
                case JunctionType.SPD: return Speed;
                case JunctionType.LCK: return Luck;
                default: throw new NotImplementedException();
            }
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
