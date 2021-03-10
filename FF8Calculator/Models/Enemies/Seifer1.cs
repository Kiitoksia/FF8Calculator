using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Seifer1 : EnemyModel
    {
        public Seifer1() : base(49, "Seifer 1", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "1.25(Lv)² + 25(Lv) + 150";

        public override string StrengthFormula => "([2(Lv)] + [(Lv) / 5] - [(Lv)² / 400] + 70) / 4";

        public override string MagicFormula => "([9(Lv)] + [(Lv) / 100] - [(Lv)² / 200] + 50) / 4";

        public override string VitalityFormula => "(Lv) - [(Lv) / 3] + (Lv) + 80";

        public override string SpiritFormula => "((Lv) / 4) - [(Lv) / 3] + (Lv) + 120";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 12] + 5";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 30] + 3";

        public override string ExperienceFormula => "0";
    }
}