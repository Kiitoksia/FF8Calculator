using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class MobileType8 : EnemyModel
    {
        public MobileType8() : base(94, "Mobile Type 8")
        {

        }

        public override string HPFormula => "400(Lv) + 30000";

        public override string StrengthFormula => "([7.5(Lv)] + [(Lv) / 100] - [(Lv)² / 260] + 85) / 4";

        public override string MagicFormula => "([6.5(Lv)] + [(Lv) / 2] - [(Lv)² / 500] + 250) / 4";

        public override string VitalityFormula => "((Lv) / 20) + 10";

        public override string SpiritFormula => "((Lv) / 50) + 10";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 6] + 30";

        public override string EvasionFormula => "((Lv) / 18) - [(Lv) / 36]";

        public override string ExperienceFormula => "0";
    }
}