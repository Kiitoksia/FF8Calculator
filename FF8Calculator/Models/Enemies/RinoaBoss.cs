using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class RinoaBoss : EnemyModel
    {
        public RinoaBoss() : base(99, "Rinoa (Boss)")
        {

        }

        public override string HPFormula => "(Lv)² + 20(Lv) + 6000";

        public override string StrengthFormula => "([(Lv)] + [(Lv) / 3] - [(Lv)² / 260] + 16) / 4";

        public override string MagicFormula => "([7.5(Lv)] + [(Lv) / 3] - [(Lv)² / 500] + 255) / 4";

        public override string VitalityFormula => "1";

        public override string SpiritFormula => "((Lv) / 8) + 1";

        public override string SpeedFormula => "20";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}