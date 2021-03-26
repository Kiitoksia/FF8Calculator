using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Propagator : EnemyModel
    {
        public Propagator() : base(85, "Propagator")
        {

        }

        public override string HPFormula => "100(Lv) + 1000";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 3] - [(Lv)² / 280] + 160) / 4";

        public override string MagicFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 500] + 2) / 4";

        public override string VitalityFormula => "((Lv) / 8) + 36";

        public override string SpiritFormula => "((Lv) / 32) + 38";

        public override string SpeedFormula => "((Lv) / 6) - [(Lv) / 12] + 76";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 12]";

        public override string ExperienceFormula => "0";
    }
}