using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Oilboyle : EnemyModel
    {
        public Oilboyle() : base(61, "Oilboyle", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.3(Lv)² + 106(Lv) + 2030";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 6] - [(Lv)² / 400] + 140) / 4";

        public override string MagicFormula => "([4.8(Lv)] + [(Lv) / 2] - [(Lv)² / 300] + 100) / 4";

        public override string VitalityFormula => "((Lv) / 20) - [(Lv) / 2] + 2(Lv) + 45";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 75";

        public override string SpeedFormula => "6";

        public override string EvasionFormula => "((Lv) / 7) - [(Lv) / 14]";

        public override string ExperienceFormula => "10(Lv)² + 30";
    }
}