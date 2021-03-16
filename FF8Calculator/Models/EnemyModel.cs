using Jace;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public abstract class EnemyModel : BaseModel
    {

        private int _hp;
        private int _evasion;
        private int _experience;
        private int _magic;
        private int _speed;
        private int _spirit;
        private int _strength;
        private int _vitality;

        public EnemyModel(int id, string name, Element[] immunities, Element[] weaknesses)
        {
            ID = id;
            Name = name;
            Immunities = immunities;
            Weaknesses = weaknesses;

            FixedStats = new List<StatModel>();
        }

        private string CleanupFormula(string formula)
        {
            formula = formula.Replace("(Lv)", "Lv");
            formula = formula.Replace("[", string.Empty);
            formula = formula.Replace("]", string.Empty);
            formula = formula.Replace("²", "^2");

            for (int i = 0; i <= 9; i++)
            {
                formula = formula.Replace($"{i}Lv", $"{i}*Lv");
            }
            return formula;
        }

        private int Round(double value) => (int)Math.Round(value);

        public string Display => $"{Name} (#{ID.ToString().PadLeft(3, '0')})";
        public int Evasion
        {
            get => _evasion; 
            private set
            {
                if (_evasion == value)
                    return;
                _evasion = value;
                OnPropertyChanged();
            }
        }
        public abstract string EvasionFormula { get; }
        public int Experience
        {
            get => _experience; 
            private set
            {
                if (_experience == value)
                    return;
                _experience = value;
                OnPropertyChanged();
            }
        }
        public abstract string ExperienceFormula { get; }
        public int HP
        {
            get => _hp; 
            private set
            {
                if (_hp == value)
                    return;
                _hp = value;
                OnPropertyChanged();
            }
        }

        public abstract string HPFormula { get; }
        public int ID { get; }
        public Element[] Immunities { get; }
        private int _level;
        public int Level
        {
            get => _level; 
            private set
            {
                if (_level == value)
                    return;
                _level = value;
                OnPropertyChanged();
            }
        }
        public int Magic
        {
            get => _magic; 
            private set
            {
                if (_magic == value)
                    return;
                _magic = value;
                OnPropertyChanged();
            }
        }
        public abstract string MagicFormula { get; }

        public string Name { get; }
        public int Speed
        {
            get => _speed; 
            private set
            {
                if (_speed == value)
                    return;
                _speed = value;
                OnPropertyChanged();
            }
        }
        public abstract string SpeedFormula { get; }
        public int Spirit
        {
            get => _spirit; 
            private set
            {
                if (_spirit == value)
                    return;
                _spirit = value;
                OnPropertyChanged();
            }
        }
        public abstract string SpiritFormula { get; }
        public int Strength
        {
            get => _strength; 
            private set
            {
                if (_strength == value)
                    return;
                _strength = value;
                OnPropertyChanged();
            }
        }
        public abstract string StrengthFormula { get; }
        public int Vitality
        {
            get => _vitality; 
            private set
            {
                if (_vitality == value)
                    return;
                _vitality = value;
                OnPropertyChanged();
            }
        }
        public abstract string VitalityFormula { get; }
        public Element[] Weaknesses { get; }

        public void CalculateStats(int level)
        {
            Level = level;
            
            if (FixedStats.Any())
            {
                StatModel stat = FixedStats[level - 1];
                HP = stat.HP;
                Strength = stat.Strength;
                Magic = stat.Magic;
                Vitality = stat.Vitality;
                Spirit = stat.Spirit;
                Speed = stat.Speed;
                Evasion = 0;
                Experience = 0;
            }
            else
            {
                CalculationEngine engine = new CalculationEngine();
                Dictionary<string, double> variableDict = new Dictionary<string, double>();
                variableDict.Add("Lv", level);

                HP = Round(engine.Calculate(CleanupFormula(HPFormula), variableDict));
                Strength = Round(engine.Calculate(CleanupFormula(StrengthFormula), variableDict));
                Magic = Round(engine.Calculate(CleanupFormula(MagicFormula), variableDict));
                Vitality = Round(engine.Calculate(CleanupFormula(VitalityFormula), variableDict));
                Spirit = Round(engine.Calculate(CleanupFormula(SpiritFormula), variableDict));
                Speed = Round(engine.Calculate(CleanupFormula(SpeedFormula), variableDict));
                Evasion = Round(engine.Calculate(CleanupFormula(EvasionFormula), variableDict));
                Experience = Round(engine.Calculate(CleanupFormula(ExperienceFormula), variableDict));
            }            
        }

        public List<StatModel> FixedStats { get; }

        public EnemyModel Clone()
        {
            return (EnemyModel)MemberwiseClone();
        }

    }
}
