using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class MagicDamageModel : BaseDamageModel
    {

        private AbilityModel _attackType;
        private int _casterMagic;
        private int _drawCastMaxDamage;
        private int _drawCastMinDamage;
        private EnemyModel _target;


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
            AttackType = AttackTypes[0]; // Default to first

            MultiplierModel.Create(this, "Raldo Defence Mode", 0.67m);
            MultiplierModel.Create(this, "Invulnerable", 0);
            MultiplierModel.Create(this, "Shell", 0.5m);
            MultiplierModel.Create(this, "Elemental Multiplier", 2);
        }

        public AbilityModel AttackType
        {
            get => _attackType;
            set
            {
                if (_attackType == value)
                    return;
                _attackType = value;
                Calculate();
                OnPropertyChanged();
            }
        }


        public List<AbilityModel> AttackTypes { get; set; }

        public int CasterMagic
        {
            get => _casterMagic;
            set
            {
                if (_casterMagic == value)
                    return;
                _casterMagic = value;
                OnPropertyChanged();
                Calculate();
            }
        }
        public int DrawCastMaxDamage
        {
            get => _drawCastMaxDamage;
            private set
            {
                if (_drawCastMaxDamage == value)
                    return;
                _drawCastMaxDamage = value;
                OnPropertyChanged();
            }
        }
        public int DrawCastMinDamage
        {
            get => _drawCastMinDamage;
            private set
            {
                if (_drawCastMinDamage == value)
                    return;
                _drawCastMinDamage = value;
                OnPropertyChanged();
            }
        }

        public EnemyModel Target
        {
            get => _target;
            set
            {
                if (_target == value)
                    return;
                _target = value;
                OnPropertyChanged();
                Calculate();
            }
        }

        public override void Calculate()
        {
            if (Target == null) return; // TODO Reset everything to zero
            decimal damageA = RoundDown(CasterMagic + AttackType.Power);
            decimal damageB = RoundDown(damageA * (265 - Target.Spirit) / 4m);

            BaseDamage = RoundDown(damageB * AttackType.Power / 256m);
            TargetHP = Target.HP;

            base.Calculate();
            DrawCastMinDamage = RoundDown(BaseDamage * (0 + 10) / 150);
            DrawCastMinDamage = ApplyMultipliers(DrawCastMinDamage);
            DrawCastMaxDamage = RoundDown(BaseDamage * (255 + 10) / 150);
            DrawCastMaxDamage = ApplyMultipliers(DrawCastMaxDamage);
        }

    }
}
