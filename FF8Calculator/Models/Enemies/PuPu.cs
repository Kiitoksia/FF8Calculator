using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class PuPu : EnemyModel
    {
        public PuPu() : base(114, "PuPu")
        {

        }

        public override string HPFormula => "10";

        public override string StrengthFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 12) / 4";

        public override string MagicFormula => "([0.5(Lv)] + [(Lv) / 6] - [(Lv)² / 500] + 8) / 4";

        public override string VitalityFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 1";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 1";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 16] + 26";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "(Lv)²";
    }
}