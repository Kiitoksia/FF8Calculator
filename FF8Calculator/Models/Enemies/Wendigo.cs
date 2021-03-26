using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Wendigo : EnemyModel
    {
        public Wendigo() : base(27, "Wendigo")
        {

        }

        public override string HPFormula => "1.25(Lv)² + 25(Lv) + 1000";

        public override string StrengthFormula => "([5.5(Lv)] + [(Lv) / 4] - [(Lv)² / 100] + 24) / 4";

        public override string MagicFormula => "([1.1(Lv)] + [(Lv) / 5] - [(Lv)² / 400] + 12) / 4";

        public override string VitalityFormula => "((Lv) / 11) - [(Lv) / 2] + (Lv) + 2";

        public override string SpiritFormula => "((Lv) / 8) + 4";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 4] + 12";

        public override string EvasionFormula => "((Lv) / 12) - [(Lv) / 24] + 1";

        public override string ExperienceFormula => "5(Lv)² + 25";
    }
}