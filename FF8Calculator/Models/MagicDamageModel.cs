using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class MagicDamageModel : BaseDamageModel
    {
        public MagicDamageModel()
        {
            AttackTypes = new List<AbilityModel>();
            AttackTypes.Add(new AbilityModel("Fire", 18));
            AttackTypes.Add(new AbilityModel("Fira", 24));
            AttackTypes.Add(new AbilityModel("Firaga", 35));
            AttackTypes.Add(new AbilityModel("Water", 26));
            AttackTypes.Add(new AbilityModel("Meltdown", 32));
            AttackTypes.Add(new AbilityModel("Flare / Holy", 48));
            AttackTypes.Add(new AbilityModel("Ultima", 80));
            AttackTypes.Add(new AbilityModel("Aero", 22));
            AttackTypes.Add(new AbilityModel("Tornado", 38));
            AttackTypes.Add(new AbilityModel("Quake", 40));
            AttackTypes.Add(new AbilityModel("Meteor", 20));

            Multipliers.Add(new MultiplierModel("Raldo Defence Mode", 0.67m));
            Multipliers.Add(new MultiplierModel("Invulnerable", 0));
            Multipliers.Add(new MultiplierModel("Shell", 0.5m));
            Multipliers.Add(new MultiplierModel("Elemental Multiplier", 2));
        }

        public int CasterMagic { get; set; }
        public int TargetSpirit { get; set; }

        public List<AbilityModel> AttackTypes { get; set; }
        public AbilityModel AttackType { get; set; }

        public int DrawCastMinDamage { get; set; }
        public int DrawCastMaxDamage { get; set; }

        public void Calculate()
        {
            decimal damageA = Math.Min(RoundDown(CasterMagic + AttackType.Power), 9999);
            decimal damageB = Math.Min(RoundDown(damageA * (265 - TargetSpirit) / 4), 9999);
            
            BaseDamage = Math.Min(RoundDown(damageB * AttackType.Power / 256), 9999);
            
            CalculateBase();
            DrawCastMinDamage = Math.Min(RoundDown(BaseDamage * (0 + 10) / 150), 9999);
            DrawCastMinDamage = ApplyMultipliers(DrawCastMinDamage);
            DrawCastMaxDamage = Math.Min(RoundDown(BaseDamage * (255 + 10) / 150), 9999);
            DrawCastMaxDamage = ApplyMultipliers(DrawCastMaxDamage);
        }

    }
}
