using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Bahamut : EnemyModel
    {
        public Bahamut() : base(111, "Bahamut")
        {

        }

        public override string HPFormula => "800(Lv) + 10000";

        public override string StrengthFormula => "([18(Lv)] + [(Lv) / 3] - [(Lv)² / 260] + 220) / 4";

        public override string MagicFormula => "([9(Lv)] + [(Lv) / 3] - [(Lv)² / 60] + 240) / 4";

        public override string VitalityFormula => "(Lv) + 70";

        public override string SpiritFormula => "((Lv) / 18) - (Lv) + 2(Lv) + 15";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 10] + 10";

        public override string EvasionFormula => "((Lv) / 4) - [(Lv) / 12]";

        public override string ExperienceFormula => "0";
    }
}