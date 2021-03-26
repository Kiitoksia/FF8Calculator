using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class LeftOrb : EnemyModel
    {
        public LeftOrb() : base(63, "Left Orb")
        {

        }

        public override string HPFormula => "2.25(Lv)² + 45(Lv) + 10";

        public override string StrengthFormula => "([6.6(Lv)] + [(Lv) / 5] - [(Lv)² / 300] + 40) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 6] - [(Lv)² / 400] + 8) / 4";

        public override string VitalityFormula => "255";

        public override string SpiritFormula => "255";

        public override string SpeedFormula => "(Lv) - [(Lv) / 3] + 10";

        public override string EvasionFormula => "((Lv) / 12) - [(Lv) / 24]";

        public override string ExperienceFormula => "0";
    }
}