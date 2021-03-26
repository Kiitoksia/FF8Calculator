using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Ochu : EnemyModel
    {
        public Ochu() : base(28, "Ochu")
        {

        }

        public override string HPFormula => "2.5(Lv)² + 150(Lv)";

        public override string StrengthFormula => "([7(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 70) / 4";

        public override string MagicFormula => "([9(Lv)] - [(Lv)² / 400] + 30) / 4";

        public override string VitalityFormula => "((Lv) / 5) + 20";

        public override string SpiritFormula => "((Lv) / 16) + 16";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 10] + 4";

        public override string EvasionFormula => "0";

        public override string ExperienceFormula => "20(Lv)² + 120";
    }
}