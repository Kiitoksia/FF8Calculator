using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class PhysicalDamageModel : BaseDamageModel
    {
        private AbilityModel _attackType;

        public PhysicalDamageModel()
        {
            MultiplierModel.Create(this, "Trigger", 1.5m);
            MultiplierModel.Create(this, "Back Attack", 2);
            MultiplierModel.Create(this, "Critical Strike", 2);
            MultiplierModel.Create(this, "Raldo Defense Mode", 0.67m); // TODO Check with Windows
            MultiplierModel.Create(this, "Invulnerable", 0);
            MultiplierModel.Create(this, "Berserk", 1.5m);
            MultiplierModel.Create(this, "Protect", 0.5m);
            MultiplierModel.Create(this, "Darkside", 3);
            
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

        public int ElemAttack { get; set; }
        public int ElemDefence { get; set; }
        
        public List<AbilityModel> AttackTypes { get; }
        public AbilityModel AttackType
        {
            get => _attackType; set
            {
                if (_attackType == value)
                    return;
                _attackType = value;
                Calculate();
                OnPropertyChanged();
            }
        }

        public int ElementalDamage { get; set; }
        public int MinElementalDamage { get; set; }
        public int MaxElementalDamage { get; set; }

        private int attackerStrength;
        public int AttackerStrength
        {
            get => attackerStrength; set
            {
                if (attackerStrength == value)
                    return;
                attackerStrength = value;
                OnPropertyChanged();
                Calculate();
            }
        }

        private EnemyModel target;
        public EnemyModel Target
        {
            get => target; set
            {
                if (target == value)
                    return;
                target = value;
                Calculate();
                OnPropertyChanged();
            }
        }

        public override void Calculate()
        {
            if (Target == null) return; // TODO Reset everything to zero
            decimal damageA = RoundDown((decimal)Math.Pow(AttackerStrength, 2) / 16m) + AttackerStrength;
            decimal damageB = RoundDown(damageA * (265 - Target.Vitality) / 256m);
            BaseDamageWithoutMultipliers = RoundDown((damageB * AttackType.Power / 16m));
            BaseDamage = RoundDown(ApplyMultipliers(BaseDamageWithoutMultipliers));

            TargetHP = Target.HP;
            
            base.Calculate();
            
            ElementalDamage = RoundDown(Math.Min(BaseDamage + BaseDamage * ElemAttack * (800 - ElemDefence) / 10000, 9999));
            MinElementalDamage = RoundDown(Math.Min(MinimumDamage + MinimumDamage * ElemAttack * (800 - ElemDefence / 10000), 9999));
            MinElementalDamage = RoundDown(Math.Min(MaximumDamage + MaximumDamage * ElemAttack * (800 - ElemDefence / 10000), 9999));
        }

                
    }
}
