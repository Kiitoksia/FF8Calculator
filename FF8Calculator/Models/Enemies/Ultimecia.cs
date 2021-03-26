using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Ultimecia : EnemyModel
    {
        public Ultimecia() : base(125, "Ultimecia")
        {

        }

        public override string HPFormula => "600(Lv) + 4000";

        public override string StrengthFormula => "([6(Lv)] - [(Lv)² / 360] + 190) / 4";

        public override string MagicFormula => "([18(Lv)] + [(Lv) / 2] - [(Lv)² / 20] + 200) / 4";

        public override string VitalityFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 80";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 80";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 16] + 110";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}