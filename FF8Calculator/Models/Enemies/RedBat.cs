using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class RedBat : EnemyModel
    {
        public RedBat() : base(6, "Red Bat")
        {

        }

        public override string HPFormula => "0.15(Lv)² + 3(Lv) + 20";

        public override string StrengthFormula => "([3.8(Lv)] + [(Lv) / 2] - [(Lv)² / 44] + 2) / 4";

        public override string MagicFormula => "([1.4(Lv)] + [(Lv) / 2] - [(Lv)² / 300] + 3) / 4";

        public override string VitalityFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 1";

        public override string SpiritFormula => "((Lv) / 5) + 4";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 6";

        public override string EvasionFormula => "((Lv) / 3) - [(Lv) / 6] + 10";

        public override string ExperienceFormula => "3(Lv)² + 5";
    }
}