using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Edea1 : EnemyModel
    {
        public Edea1() : base(50, "Edea 1")
        {

        }

        public override string HPFormula => "300(Lv) + 1000";

        public override string StrengthFormula => "([3.5(Lv)] + [(Lv) / 10] - [(Lv)² / 100] + 10) / 4";

        public override string MagicFormula => "([2(Lv)] + [(Lv) / 10] - [(Lv)² / 200] + 180) / 4";

        public override string VitalityFormula => "(Lv) + 15";

        public override string SpiritFormula => "((Lv) / 15) - [(Lv) / 8] + (Lv) + 75";

        public override string SpeedFormula => "(Lv) - [(Lv) / 12] + 5";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 16] + 1";

        public override string ExperienceFormula => "0";
    }
}