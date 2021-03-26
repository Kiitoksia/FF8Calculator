using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class BiteBug : EnemyModel
    {
        public BiteBug() : base(1, "Bite Bug")
        {

        }

        public override string HPFormula => "0.2(Lv)² + 4(Lv) + 110";

        public override string StrengthFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 6) / 4";

        public override string MagicFormula => "([2.4(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 2) / 4";

        public override string VitalityFormula => "((Lv) / 50) + 4";

        public override string SpiritFormula => "((Lv) / 6) + 2";

        public override string SpeedFormula => "((Lv) / 10) - [(Lv) / 20] + 4";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 30] + 2";

        public override string ExperienceFormula => "5(Lv)² + 10";
    }
}