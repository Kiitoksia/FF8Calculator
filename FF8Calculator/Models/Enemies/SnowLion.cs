using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class SnowLion : EnemyModel
    {
        public SnowLion() : base(71, "Snow Lion", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "3(Lv)² + 1060(Lv)";

        public override string StrengthFormula => "([6.2(Lv)] + [(Lv) / 5] - [(Lv)² / 240] + 60) / 4";

        public override string MagicFormula => "([5(Lv)] + [(Lv) / 2] - [(Lv)² / 280]) / 4";

        public override string VitalityFormula => "((Lv) / 3) + 25";

        public override string SpiritFormula => "((Lv) / 6) + 8";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 10";

        public override string EvasionFormula => "((Lv) / 12) - [(Lv) / 24]";

        public override string ExperienceFormula => "20(Lv)² + 130";
    }
}