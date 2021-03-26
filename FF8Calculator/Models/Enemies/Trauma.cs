using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Trauma : EnemyModel
    {
        public Trauma() : base(118, "Trauma")
        {

        }

        public override string HPFormula => "0.25(Lv)² + 505(Lv) + 5050";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 10] - [(Lv)² / 260] + 80) / 4";

        public override string MagicFormula => "([10.1(Lv)] + [(Lv) / 20] - [(Lv)² / 300] + 40) / 4";

        public override string VitalityFormula => "180";

        public override string SpiritFormula => "36";

        public override string SpeedFormula => "24";

        public override string EvasionFormula => "3";

        public override string ExperienceFormula => "0";
    }
}