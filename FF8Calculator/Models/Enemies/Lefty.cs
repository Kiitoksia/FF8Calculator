using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Lefty : EnemyModel
    {
        public Lefty() : base(31, "Lefty")
        {

        }

        public override string HPFormula => "(Lv)² + 20(Lv) + 1800";

        public override string StrengthFormula => "([2(Lv)] + [(Lv) / 10] - [(Lv)² / 260] + 4) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 3] - [(Lv)² / 480] + 125) / 4";

        public override string VitalityFormula => "((Lv) / 11) + 1";

        public override string SpiritFormula => "((Lv) / 7) + 180";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 10] + 2";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "10(Lv)² + 30";
    }
}