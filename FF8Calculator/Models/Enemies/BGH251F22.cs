using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class BGH251F22 : EnemyModel
    {
        public BGH251F22() : base(66, "BGH251F2 2")
        {

        }

        public override string HPFormula => "100(Lv) + 5000";

        public override string StrengthFormula => "([9(Lv)] + [(Lv) / 60] - [(Lv)² / 260] + 100) / 4";

        public override string MagicFormula => "([9(Lv)] + [(Lv) / 100] - [(Lv)² / 200] + 50) / 4";

        public override string VitalityFormula => "((Lv) / 25) - [(Lv) / 2] + 2(Lv) + 50";

        public override string SpiritFormula => "((Lv) / 8) + 130";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 10] + 20";

        public override string EvasionFormula => "((Lv) / 4) - [(Lv) / 8]";

        public override string ExperienceFormula => "0";
    }
}