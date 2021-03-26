using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class IronGiant : EnemyModel
    {
        public IronGiant() : base(89, "Iron Giant")
        {

        }

        public override string HPFormula => "1.5(Lv)² + 630(Lv)";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 250] - [(Lv)² / 500] + 50) / 4";

        public override string MagicFormula => "([0.8(Lv)] + [(Lv) / 6] - [(Lv)² / 400] + 12) / 4";

        public override string VitalityFormula => "((Lv) / 16) + 120";

        public override string SpiritFormula => "((Lv) / 8) + 1";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 7";

        public override string EvasionFormula => "((Lv) / 11) - [(Lv) / 22]";

        public override string ExperienceFormula => "30(Lv)² + 110";
    }
}