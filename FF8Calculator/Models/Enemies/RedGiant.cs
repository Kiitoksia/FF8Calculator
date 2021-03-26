using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class RedGiant : EnemyModel
    {
        public RedGiant() : base(120, "Red Giant")
        {

        }

        public override string HPFormula => "30000";

        public override string StrengthFormula => "([7.5(Lv)] + [(Lv) / 4] - [(Lv)² / 260] + 100) / 4";

        public override string MagicFormula => "([0.5(Lv)] + [(Lv) / 6] - [(Lv)² / 500] + 8) / 4";

        public override string VitalityFormula => "255";

        public override string SpiritFormula => "255";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 4";

        public override string EvasionFormula => "((Lv) / 12) - [(Lv) / 24]";

        public override string ExperienceFormula => "0";
    }
}