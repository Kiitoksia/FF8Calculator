using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class StatCalculatorModel : BaseModel
    {
        private int _finalHit;
        private int _finalHP;
        private int _finalLuck;
        private int _finalMagic;
        private int _finalSpeed;
        private int _finalSpirit;
        private int _finalStrength;
        private int _finalVitality;
        private int _hitAmount;
        private StatJunctionModel _hitJunction;
        private int _hpAmount;
        private StatJunctionModel _hpJunction;
        private int _level;
        private int _luckAmount;
        private StatJunctionModel _luckJunction;
        private int _magicAmount;
        private StatJunctionModel _magicJunction;
        private EnemyModel _player;
        private int _speedAmount;
        private StatJunctionModel _speedJunction;
        private int _spiritAmount;
        private StatJunctionModel _spiritJunction;
        private int _strengthAmount;
        private StatJunctionModel _strengthJunction;
        private int _vitalityAmount;
        private StatJunctionModel _vitalityJunction;

        public StatCalculatorModel()
        {
            Stats = new List<StatJunctionModel>();
            Stats.Add(new StatJunctionModel("Ultima", 60, 1.00m, 0.82m, 1.00m, 0.95m, 0.60m, 0.24m, 0.60m, 0.60m));
            Stats.Add(new StatJunctionModel("Full-life", 48, 0.20m, 0.80m, 0.20m, 0.85m, 0.08m, 0.04m, 0.08m, 0.20m));
            Stats.Add(new StatJunctionModel("Water", 3, 0.20m, 0.14m, 0.18m, 0.14m, 0.12m, 0.04m, 0.18m, 0.13m));
            Stats.Add(new StatJunctionModel("Aero", 3, 0.17m, 0.10m, 0.16m, 0.10m, 0.20m, 0.08m, 0.22m, 0.15m));
            Stats.Add(new StatJunctionModel("Esuna", 5, 0.06m, 0.36m, 0.12m, 0.36m, 0.03m, 0.02m, 0.03m, 0.10m));
            Stats.Add(new StatJunctionModel("Aura", 34, 0.70m, 0.22m, 0.24m, 0.24m, 0.10m, 0.02m, 0.50m, 0.40m));
            Stats.Add(new StatJunctionModel("Quake", 26, 0.40m, 0.20m, 0.40m, 0.20m, 0.07m, 0.03m, 0.30m, 0.12m));
            Stats.Add(new StatJunctionModel("Demi", 16, 0.34m, 0.18m, 0.36m, 0.18m, 0.12m, 0.04m, 0.14m, 0.10m));
            Stats.Add(new StatJunctionModel("Cure", 2, 0.04m, 0.15m, 0.04m, 0.15m, 0.03m, 0.02m, 0.02m, 0.02m));
            Stats.Add(new StatJunctionModel("Cura", 5, 0.08m, 0.28m, 0.08m, 0.28m, 0.04m, 0.02m, 0.03m, 0.03m));
            Stats.Add(new StatJunctionModel("Curaga", 22, 0.20m, 0.65m, 0.20m, 0.65m, 0.10m, 0.04m, 0.10m, 0.10m));
            Stats.Add(new StatJunctionModel("Confuse", 7, 0.22m, 0.18m, 0.28m, 0.18m, 0.18m, 0.04m, 0.08m, 0.08m));
            Stats.Add(new StatJunctionModel("Silence", 1, 0.06m, 0.05m, 0.12m, 0.10m, 0.04m, 0.02m, 0.03m, 0.02m));
            Stats.Add(new StatJunctionModel("Thunder", 1, 0.10m, 0.04m, 0.10m, 0.04m, 0.08m, 0.03m, 0.10m, 0.08m));
            Stats.Add(new StatJunctionModel("Thundara", 2, 0.15m, 0.08m, 0.15m, 0.08m, 0.12m, 0.04m, 0.16m, 0.12m));
            Stats.Add(new StatJunctionModel("Thundaga", 14, 0.30m, 0.16m, 0.30m, 0.16m, 0.14m, 0.04m, 0.20m, 0.14m));
            Stats.Add(new StatJunctionModel("Shell", 4, 0.06m, 0.18m, 0.10m, 0.40m, 0.03m, 0.02m, 0.03m, 0.14m));
            Stats.Add(new StatJunctionModel("Stop", 8, 0.18m, 0.20m, 0.30m, 0.24m, 0.48m, 0.10m, 0.20m, 0.10m));
            Stats.Add(new StatJunctionModel("Sleep", 1, 0.06m, 0.05m, 0.12m, 0.10m, 0.04m, 0.04m, 0.03m, 0.02m));
            Stats.Add(new StatJunctionModel("Slow", 5, 0.12m, 0.16m, 0.20m, 0.20m, 0.40m, 0.08m, 0.10m, 0.10m));
            Stats.Add(new StatJunctionModel("Zombie", 8, 0.15m, 0.24m, 0.15m, 0.12m, 0.02m, 0.01m, 0.02m, 0.02m));
            Stats.Add(new StatJunctionModel("Double", 2, 0.15m, 0.06m, 0.18m, 0.06m, 0.10m, 0.03m, 0.40m, 0.02m));
            Stats.Add(new StatJunctionModel("Death", 18, 0.22m, 0.22m, 0.38m, 0.58m, 0.10m, 0.04m, 0.10m, 0.38m));
            Stats.Add(new StatJunctionModel("Dispel", 10, 0.12m, 0.38m, 0.16m, 0.60m, 0.08m, 0.04m, 0.08m, 0.14m));
            Stats.Add(new StatJunctionModel("Triple", 24, 0.70m, 0.10m, 0.70m, 0.10m, 0.70m, 0.16m, 1.50m, 0.30m));
            Stats.Add(new StatJunctionModel("Tornado", 30, 0.48m, 0.24m, 0.42m, 0.24m, 0.33m, 0.13m, 0.38m, 0.14m));
            Stats.Add(new StatJunctionModel("Drain", 4, 0.13m, 0.30m, 0.20m, 0.24m, 0.06m, 0.02m, 0.05m, 0.04m));
            Stats.Add(new StatJunctionModel("Berserk", 3, 0.13m, 0.08m, 0.14m, 0.08m, 0.05m, 0.02m, 0.04m, 0.03m));
            Stats.Add(new StatJunctionModel("Bio", 7, 0.24m, 0.15m, 0.24m, 0.15m, 0.05m, 0.02m, 0.04m, 0.04m));
            Stats.Add(new StatJunctionModel("Fire", 1, 0.10m, 0.04m, 0.10m, 0.04m, 0.08m, 0.03m, 0.10m, 0.08m));
            Stats.Add(new StatJunctionModel("Fira", 2, 0.15m, 0.08m, 0.15m, 0.08m, 0.12m, 0.04m, 0.16m, 0.12m));
            Stats.Add(new StatJunctionModel("Firaga", 14, 0.30m, 0.16m, 0.30m, 0.16m, 0.14m, 0.04m, 0.20m, 0.14m));
            Stats.Add(new StatJunctionModel("Blind", 1, 0.06m, 0.05m, 0.12m, 0.10m, 0.03m, 0.02m, 0.30m, 0.02m));
            Stats.Add(new StatJunctionModel("Blizzard", 1, 0.10m, 0.04m, 0.10m, 0.04m, 0.08m, 0.03m, 0.10m, 0.08m));
            Stats.Add(new StatJunctionModel("Blizzara", 2, 0.15m, 0.08m, 0.15m, 0.08m, 0.12m, 0.04m, 0.16m, 0.12m));
            Stats.Add(new StatJunctionModel("Blizzaga", 14, 0.30m, 0.16m, 0.30m, 0.16m, 0.14m, 0.04m, 0.20m, 0.14m));
            Stats.Add(new StatJunctionModel("Flare", 32, 0.56m, 0.26m, 0.44m, 0.26m, 0.12m, 0.03m, 0.26m, 0.12m));
            Stats.Add(new StatJunctionModel("Break", 10, 0.20m, 0.20m, 0.34m, 0.35m, 0.10m, 0.04m, 0.10m, 0.12m));
            Stats.Add(new StatJunctionModel("Protect", 4, 0.06m, 0.40m, 0.10m, 0.18m, 0.03m, 0.02m, 0.03m, 0.14m));
            Stats.Add(new StatJunctionModel("Haste", 5, 0.12m, 0.16m, 0.20m, 0.20m, 0.50m, 0.08m, 0.10m, 0.10m));
            Stats.Add(new StatJunctionModel("Pain", 28, 0.42m, 0.38m, 0.60m, 0.45m, 0.04m, 0.01m, 0.04m, 0.40m));
            Stats.Add(new StatJunctionModel("Holy", 38, 0.55m, 0.28m, 0.45m, 0.48m, 0.10m, 0.07m, 0.24m, 0.14m));
            Stats.Add(new StatJunctionModel("Meteor", 46, 0.75m, 0.34m, 0.52m, 0.34m, 0.30m, 0.12m, 0.40m, 0.22m));
            Stats.Add(new StatJunctionModel("Meltdown", 15, 0.24m, 0.80m, 0.20m, 0.20m, 0.03m, 0.02m, 0.12m, 0.08m));
            Stats.Add(new StatJunctionModel("Scan", 1, 0.05m, 0.05m, 0.05m, 0.05m, 0.03m, 0.02m, 0.03m, 0.03m));
            Stats.Add(new StatJunctionModel("Regen", 26, 0.18m, 0.70m, 0.18m, 0.60m, 0.08m, 0.04m, 0.08m, 0.08m));
            Stats.Add(new StatJunctionModel("Reflect", 20, 0.14m, 0.46m, 0.20m, 0.72m, 0.10m, 0.04m, 0.08m, 0.16m));
            Stats.Add(new StatJunctionModel("Life", 12, 0.08m, 0.50m, 0.10m, 0.50m, 0.04m, 0.02m, 0.03m, 0.04m));
            Stats.Add(new StatJunctionModel("Float", 2, 0.08m, 0.15m, 0.08m, 0.15m, 0.16m, 0.04m, 0.12m, 0.20m));
            Stats.Add(new StatJunctionModel("Apocalypse", 42, 0.80m, 0.80m, 0.80m, 0.90m, 0.30m, 0.12m, 0.30m, 0.30m));

            PropertyChanged += (s, e) => Calculate();
        }


        private void Calculate()
        {
            Player.CalculateStats(Level);

            FinalHP = Player.HP;
            FinalHP += (HPJunction?.HP ?? 0) * HPAmount;

            decimal value = Player.Strength;
            value += (StrengthJunction?.Strength ?? 0) * StrengthAmount;
            FinalStrength = RoundDown(value);

            value = Player.Vitality;
            value += (VitalityJunction?.Vitality ?? 0) * VitalityAmount;
            FinalVitality = RoundDown(value);

            value = Player.Magic;
            value += (MagicJunction?.Magic ?? 0) * MagicAmount;
            FinalMagic = RoundDown(value);

            value = Player.Spirit;
            value += (SpiritJunction?.Spirit ?? 0) * SpiritAmount;
            FinalSpirit = RoundDown(value);

            value = Player.Speed;
            value += (SpeedJunction?.Speed ?? 0) * SpeedAmount;
            FinalSpirit = RoundDown(value);

            value = Player.Luck;
            value += (LuckJunction?.Luck ?? 0) * LuckAmount;
            FinalLuck = RoundDown(value);
        }

        public int FinalHit
        {
            get => _finalHit; private set
            {
                if (_finalHit == value)
                    return;
                _finalHit = value;
                OnPropertyChanged();
            }
        }
        public int FinalHP
        {
            get => _finalHP; private set
            {
                if (_finalHP == value)
                    return;
                _finalHP = value;
                OnPropertyChanged();
            }
        }
        public int FinalLuck
        {
            get => _finalLuck; private set
            {
                if (_finalLuck == value)
                    return;
                _finalLuck = value;
                OnPropertyChanged();
            }
        }
        public int FinalMagic
        {
            get => _finalMagic; private set
            {
                if (_finalMagic == value)
                    return;
                _finalMagic = value;
                OnPropertyChanged();
            }
        }
        public int FinalSpeed
        {
            get => _finalSpeed; private set
            {
                if (_finalSpeed == value)
                    return;
                _finalSpeed = value;
                OnPropertyChanged();
            }
        }
        public int FinalSpirit
        {
            get => _finalSpirit; private set
            {
                if (_finalSpirit == value)
                    return;
                _finalSpirit = value;
                OnPropertyChanged();
            }
        }
        public int FinalStrength
        {
            get => _finalStrength; private set
            {
                if (_finalStrength == value)
                    return;
                _finalStrength = value;
                OnPropertyChanged();
            }
        }
        public int FinalVitality
        {
            get => _finalVitality; private set
            {
                if (_finalVitality == value)
                    return;
                _finalVitality = value;
                OnPropertyChanged();
            }
        }
        public int HitAmount
        {
            get => _hitAmount; set
            {
                if (_hitAmount == value)
                    return;
                _hitAmount = value;
                OnPropertyChanged();
            }
        }
        public StatJunctionModel HitJunction
        {
            get => _hitJunction; set
            {
                if (_hitJunction == value)
                    return;
                _hitJunction = value;
                OnPropertyChanged();
            }
        }
        public int HPAmount
        {
            get => _hpAmount; set
            {
                if (_hpAmount == value)
                    return;
                _hpAmount = value;
                OnPropertyChanged();
            }
        }
        public StatJunctionModel HPJunction
        {
            get => _hpJunction; set
            {
                if (_hpJunction == value)
                    return;
                _hpJunction = value;
                OnPropertyChanged();
            }
        }
        public int Level
        {
            get => _level; set
            {
                if (_level == value)
                    return;
                _level = value;
                OnPropertyChanged();
            }
        }
        public int LuckAmount
        {
            get => _luckAmount; set
            {
                if (_luckAmount == value)
                    return;
                _luckAmount = value;
                OnPropertyChanged();
            }
        }
        public StatJunctionModel LuckJunction
        {
            get => _luckJunction; set
            {
                if (_luckJunction == value)
                    return;
                _luckJunction = value;
                OnPropertyChanged();
            }
        }
        public int MagicAmount
        {
            get => _magicAmount; set
            {
                if (_magicAmount == value)
                    return;
                _magicAmount = value;
                OnPropertyChanged();
            }
        }
        public StatJunctionModel MagicJunction
        {
            get => _magicJunction; set
            {
                if (_magicJunction == value)
                    return;
                _magicJunction = value;
                OnPropertyChanged();
            }
        }
        public EnemyModel Player
        {
            get => _player; set
            {
                if (_player == value)
                    return;
                _player = value;
                OnPropertyChanged();
            }
        }

        public List<EnemyModel> Players { get; set; }
        public int SpeedAmount
        {
            get => _speedAmount; set
            {
                if (_speedAmount == value)
                    return;
                _speedAmount = value;
                OnPropertyChanged();
            }
        }
        public StatJunctionModel SpeedJunction
        {
            get => _speedJunction; set
            {
                if (_speedJunction == value)
                    return;
                _speedJunction = value;
                OnPropertyChanged();
            }
        }
        public int SpiritAmount
        {
            get => _spiritAmount; set
            {
                if (_spiritAmount == value)
                    return;
                _spiritAmount = value;
                OnPropertyChanged();
            }
        }
        public StatJunctionModel SpiritJunction
        {
            get => _spiritJunction; set
            {
                if (_spiritJunction == value)
                    return;
                _spiritJunction = value;
                OnPropertyChanged();
            }
        }

        public List<StatJunctionModel> Stats { get; }
        public int StrengthAmount
        {
            get => _strengthAmount; set
            {
                if (_strengthAmount == value)
                    return;
                _strengthAmount = value;
                OnPropertyChanged();
            }
        }
        public StatJunctionModel StrengthJunction
        {
            get => _strengthJunction; set
            {
                if (_strengthJunction == value)
                    return;
                _strengthJunction = value;
                OnPropertyChanged();
            }
        }
        public int VitalityAmount
        {
            get => _vitalityAmount; set
            {
                if (_vitalityAmount == value)
                    return;
                _vitalityAmount = value;
                OnPropertyChanged();
            }
        }
        public StatJunctionModel VitalityJunction
        {
            get => _vitalityJunction; set
            {
                if (_vitalityJunction == value)
                    return;
                _vitalityJunction = value;
                OnPropertyChanged();
            }
        }

    }

}
