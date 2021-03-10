using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class GIM52A : EnemyModel
    {
        public GIM52A() : base(53, "GIM52A", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "1.5(Lv)² + 30(Lv) + 1400";

        public override string StrengthFormula => "([5.3(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 50) / 4";

        public override string MagicFormula => "([4(Lv)] + [(Lv) / 2] - [(Lv)² / 200] + 18) / 4";

        public override string VitalityFormula => "((Lv) / 40) - (Lv) + 2(Lv) + 2";

        public override string SpiritFormula => "((Lv) / 8) + 120";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 5";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "8(Lv)² + 22";
    }
}