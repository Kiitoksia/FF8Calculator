using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Seifer2 : EnemyModel
    {
        public Seifer2() : base(79, "Seifer 2")
        {

        }

        public override string HPFormula => "300(Lv) + 1000";

        public override string StrengthFormula => "([7.5(Lv)] - [(Lv)² / 100] + 120) / 4";

        public override string MagicFormula => "([8.5(Lv)] + [(Lv) / 80] - [(Lv)² / 300] + 100) / 4";

        public override string VitalityFormula => "2(Lv) + 12";

        public override string SpiritFormula => "((Lv) / 5) - [(Lv) / 4] + (Lv) + 135";

        public override string SpeedFormula => "(Lv) - [(Lv) / 10] + 30";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 24] + 2";

        public override string ExperienceFormula => "0";
    }
}