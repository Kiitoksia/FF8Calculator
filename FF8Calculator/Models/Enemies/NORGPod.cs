using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class NORGPod : EnemyModel
    {
        public NORGPod() : base(62, "NORG Pod")
        {

        }

        public override string HPFormula => "2000";

        public override string StrengthFormula => "([0.8(Lv)] + [(Lv) / 200] - [(Lv)² / 400] + 4) / 4";

        public override string MagicFormula => "([2(Lv)] + [(Lv) / 2] - [(Lv)² / 500] + 4) / 4";

        public override string VitalityFormula => "((Lv) / 4) + 150";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 4] + (Lv) + 170";

        public override string SpeedFormula => "(Lv) - [(Lv) / 10] + 55";

        public override string EvasionFormula => "1";

        public override string ExperienceFormula => "0";
    }
}