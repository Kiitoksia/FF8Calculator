using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class SorceressA : EnemyModel
    {
        public SorceressA() : base(100, "SorceressA")
        {

        }

        public override string HPFormula => "0.8(Lv)² + 16(Lv) + 1050";

        public override string StrengthFormula => "([5(Lv)] + [(Lv) / 4] - [(Lv)² / 500] + 60) / 4";

        public override string MagicFormula => "([18(Lv)] + [(Lv) / 7] - [(Lv)² / 200] + 5) / 4";

        public override string VitalityFormula => "10";

        public override string SpiritFormula => "1";

        public override string SpeedFormula => "50";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}