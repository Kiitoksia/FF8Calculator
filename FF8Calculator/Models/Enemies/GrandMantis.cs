using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class GrandMantis : EnemyModel
    {
        public GrandMantis() : base(47, "Grand Mantis")
        {

        }

        public override string HPFormula => "0.65(Lv)² + 13(Lv) + 5200";

        public override string StrengthFormula => "([4(Lv)] + [(Lv) / 5] - [(Lv)² / 160] + 30) / 4";

        public override string MagicFormula => "([0.5(Lv)] + [(Lv) / 6] - [(Lv)² / 500] + 8) / 4";

        public override string VitalityFormula => "((Lv) / 4) + 150";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 1";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 10] + 3";

        public override string EvasionFormula => "((Lv) / 14) - [(Lv) / 28]";

        public override string ExperienceFormula => "20(Lv)² + 60";
    }
}