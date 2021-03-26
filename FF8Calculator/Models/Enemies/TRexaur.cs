using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class TRexaur : EnemyModel
    {
        public TRexaur() : base(5, "T-Rexaur")
        {

        }

        public override string HPFormula => "3(Lv)² + 360(Lv) + 10000";

        public override string StrengthFormula => "([9(Lv)] + [(Lv) / 5] - [(Lv)² / 420] + 60) / 4";

        public override string MagicFormula => "([1.2(Lv)] + [(Lv) / 2] - [(Lv)² / 120] + 4) / 4";

        public override string VitalityFormula => "((Lv) / 8) + 6";

        public override string SpiritFormula => "((Lv) / 24) + 35";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 10] + 3";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "10(Lv)² + 150";
    }
}