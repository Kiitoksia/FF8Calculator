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
        public EnemyModel(int id, string name, Element[] immunities, Element[] weaknesses)
        {
            ID = id;
            Name = name;
            Immunities = immunities;
            Weaknesses = weaknesses;
        }

        public string Name { get; }
        public int ID { get; }
        public int Level { get; set; }

        public int HP { get; private set; }
        public int Strength { get; private set; }
        public int Magic { get; private set; }
        public int Vitality { get; private set; }
        public int Spirit { get; private set; }
        public int Speed { get; private set; }
        public int Evasion { get; private set; }
        public int Experience { get; private set; }
        public Element[] Immunities { get; }
        public Element[] Weaknesses { get; }

        public abstract string HPFormula { get; }
        public abstract string StrengthFormula { get;  }
        public abstract string MagicFormula { get; }
        public abstract string VitalityFormula { get; }
        public abstract string SpiritFormula { get; }
        public abstract string SpeedFormula { get; }
        public abstract string EvasionFormula { get; }
        public abstract string ExperienceFormula { get; }

        public void CalculateStats(int level)
        {
            Level = level;

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

        private string CleanupFormula(string formula)
        {
            formula = formula.Replace("(Lv)", "Lv");
            formula = formula.Replace("[", string.Empty);
            formula = formula.Replace("]", string.Empty);
            formula = formula.Replace("²", "^2");

            for (int i = 0; i < 9; i++)
            {
                formula = formula.Replace($"{i}Lv", $"{i}*Lv");
            }
            return formula;
        }

        private int Round(double value) => (int)Math.Floor(value);
    }
}
