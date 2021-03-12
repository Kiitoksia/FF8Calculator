using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class PhysicalDamageModel : BaseDamageModel
    {
        public PhysicalDamageModel()
        {
            Multipliers.Add(new MultiplierModel("Trigger", 1.5m));
            Multipliers.Add(new MultiplierModel("Back Attack", 2));
            Multipliers.Add(new MultiplierModel("Critical Strike", 2));
            Multipliers.Add(new MultiplierModel("Raldo Defense Mode", 0.67m)); // TODO Check with Windows
            Multipliers.Add(new MultiplierModel("Invulnerable", 0));
            Multipliers.Add(new MultiplierModel("Berserk", 1.5m));
            Multipliers.Add(new MultiplierModel("Protect", 0.5m));
            Multipliers.Add(new MultiplierModel("Darkside", 3));
            
            AttackTypes = new List<AbilityModel>();
            AttackTypes.Add(new AbilityModel("Basic Attack", 20));
            AttackTypes.Add(new AbilityModel("Renzokuken Hit", 22));
            AttackTypes.Add(new AbilityModel("Normal Ammo", 17));
            AttackTypes.Add(new AbilityModel("Shotgun Ammo", 14));
            AttackTypes.Add(new AbilityModel("Fast Ammo", 7));
            AttackTypes.Add(new AbilityModel("Fire Ammo", 40));
            AttackTypes.Add(new AbilityModel("Demolition Ammo", 60));
            AttackTypes.Add(new AbilityModel("AP Ammo", 80));
            AttackTypes.Add(new AbilityModel("Pulse Ammo", 120));
            AttackTypes.Add(new AbilityModel("Dark Ammo", 14));
            AttackTypes.Add(new AbilityModel("Angelo Cannon", 72));
            AttackType = AttackTypes[0]; // Default to Basic Attack
        }

        public int AttackerStrength { get; set; }
        public int TargetVitality { get; set; }   
        public int ElemAttack { get; set; }
        public int ElemDefence { get; set; }
        
        public List<AbilityModel> AttackTypes { get; }
        private AbilityModel attackType;
        public AbilityModel AttackType
        {
            get => attackType; set
            {
                if (attackType == value)
                    return;
                attackType = value;
                OnPropertyChanged();
            }
        }

        public int ElementalDamage { get; set; }
        public int MinElementalDamage { get; set; }
        public int MaxElementalDamage { get; set; }

        public void Calculate()
        {
            decimal damageA = RoundDown(AttackerStrength ^ 2 / 16 + AttackerStrength);
            decimal damageB = RoundDown(damageA * (265 - TargetVitality) / 256);
            BaseDamage = RoundDown(damageB * AttackType.Power / 16);

            CalculateBase();
            
            ElementalDamage = RoundDown(Math.Min(BaseDamage + BaseDamage * ElemAttack * (800 - ElemDefence) / 10000, 9999));
            MinElementalDamage = RoundDown(Math.Min(MinimumDamage + MinimumDamage * ElemAttack * (800 - ElemDefence / 10000), 9999));
            MinElementalDamage = RoundDown(Math.Min(MaximumDamage + MaximumDamage * ElemAttack * (800 - ElemDefence / 10000), 9999));
        }

                
    }
}
