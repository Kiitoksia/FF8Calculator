using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class UltimeciaLower : EnemyModel
    {
        public UltimeciaLower() : base(129, "Ultimecia (Final Boss - Lower)")
        {

        }

        public override string HPFormula => "4100(Lv) + 12400";

        public override string StrengthFormula => "([6(Lv)] - [(Lv)² / 360] + 190) / 4";

        public override string MagicFormula => "([18(Lv)] + [(Lv) / 2] - [(Lv)² / 12] + 200) / 4";

        public override string VitalityFormula => "(Lv) + 1";

        public override string SpiritFormula => "((Lv) / 50) - [(Lv) / 2] + (Lv) + 3";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 16] + 26";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}