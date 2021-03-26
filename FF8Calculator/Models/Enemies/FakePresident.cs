using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class FakePresident : EnemyModel
    {
        public FakePresident() : base(23, "Fake President")
        {

        }

        public override string HPFormula => "2(Lv)² + 40(Lv) + 10";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 12) / 4";

        public override string MagicFormula => "([5(Lv)] + [(Lv) / 5] - [(Lv)² / 500] + 100) / 4";

        public override string VitalityFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 45";

        public override string SpiritFormula => "((Lv) / 12) - [(Lv) / 2] + (Lv) + 50";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 6] + 6";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 16]";

        public override string ExperienceFormula => "0";
    }
}