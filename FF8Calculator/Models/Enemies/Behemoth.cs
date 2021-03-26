using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Behemoth : EnemyModel
    {
        public Behemoth() : base(91, "Behemoth")
        {

        }

        public override string HPFormula => "(Lv)² + 220(Lv) + 35000";

        public override string StrengthFormula => "([7.7(Lv)] + [(Lv) / 250] - [(Lv)² / 500] + 250) / 4";

        public override string MagicFormula => "([10(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 4) / 4";

        public override string VitalityFormula => "((Lv) / 16) + 12";

        public override string SpiritFormula => "((Lv) / 2) - [(Lv) / 4] + 2(Lv) + 1";

        public override string SpeedFormula => "((Lv) / 8) - [(Lv) / 16] + 3";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 16]";

        public override string ExperienceFormula => "30(Lv)² + 170";
    }
}