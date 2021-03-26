using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Gesper : EnemyModel
    {
        public Gesper() : base(36, "Gesper")
        {

        }

        public override string HPFormula => "1.2(Lv)² + 24(Lv) + 500";

        public override string StrengthFormula => "([4.4(Lv)] + [(Lv) / 30] - [(Lv)² / 400] + 20) / 4";

        public override string MagicFormula => "([5(Lv)] + [(Lv) / 7] - [(Lv)² / 280] + 200) / 4";

        public override string VitalityFormula => "((Lv) / 12) + 10";

        public override string SpiritFormula => "((Lv) / 10) + 60";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 4] + 4";

        public override string EvasionFormula => "((Lv) / 15) - [(Lv) / 30] + 3";

        public override string ExperienceFormula => "8(Lv)² + 24";
    }
}