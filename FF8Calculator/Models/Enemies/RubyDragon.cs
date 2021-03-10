using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class RubyDragon : EnemyModel
    {
        public RubyDragon() : base(82, "Ruby Dragon", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "3.25(Lv)² + 565(Lv) + 100";

        public override string StrengthFormula => "([9.2(Lv)] + [(Lv) / 250] - [(Lv)² / 500] + 100) / 4";

        public override string MagicFormula => "([7(Lv)] + [(Lv) / 4] - [(Lv)² / 500] + 255) / 4";

        public override string VitalityFormula => "(Lv) + 80";

        public override string SpiritFormula => "((Lv) / 22) - [(Lv) / 3] + (Lv) + 150";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 2";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 16]";

        public override string ExperienceFormula => "40(Lv)² + 170";
    }
}