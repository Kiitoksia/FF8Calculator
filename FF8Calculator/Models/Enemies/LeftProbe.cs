using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class LeftProbe : EnemyModel
    {
        public LeftProbe() : base(95, "Left Probe")
        {

        }

        public override string HPFormula => "100(Lv) + 5000";

        public override string StrengthFormula => "(([5(Lv)] + [(Lv) / 4] - [(Lv)² / 400] + 45) / 4";

        public override string MagicFormula => "([9(Lv)] + [(Lv) / 2] - [(Lv)² / 200] + 30) / 4";

        public override string VitalityFormula => "255";

        public override string SpiritFormula => "255";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 6] + 30";

        public override string EvasionFormula => "((Lv) / 4) - [(Lv) / 12] + 15";

        public override string ExperienceFormula => "0";
    }
}