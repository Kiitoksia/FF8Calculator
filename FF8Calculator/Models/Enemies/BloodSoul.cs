using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class BloodSoul : EnemyModel
    {
        public BloodSoul() : base(38, "BloodSoul")
        {

        }

        public override string HPFormula => "0.5(Lv)² + 10(Lv) + 500";

        public override string StrengthFormula => "([2.5(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 15) / 4";

        public override string MagicFormula => "([4.4(Lv)] + [(Lv) / 3] - [(Lv)² / 300] + 37) / 4";

        public override string VitalityFormula => "((Lv) / 16) - [(Lv) / 2] + (Lv) + 6";

        public override string SpiritFormula => "((Lv) / 3) + 150";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 8";

        public override string EvasionFormula => "((Lv) / 11) - [(Lv) / 22]";

        public override string ExperienceFormula => "5(Lv)² + 10";
    }
}