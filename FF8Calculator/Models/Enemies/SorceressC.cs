using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class SorceressC : EnemyModel
    {
        public SorceressC() : base(102, "SorceressC")
        {

        }

        public override string HPFormula => "0.8(Lv)² + 500(Lv) + 10000";

        public override string StrengthFormula => "([9(Lv)] + [(Lv) / 4] - [(Lv)² / 500] + 90) / 4";

        public override string MagicFormula => "([21(Lv)] - [(Lv)² / 16] + 250) / 4";

        public override string VitalityFormula => "((Lv) / 14) - [(Lv) / 5] + (Lv) + 80";

        public override string SpiritFormula => "30";

        public override string SpeedFormula => "50";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}