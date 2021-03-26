using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Droma : EnemyModel
    {
        public Droma() : base(119, "Droma")
        {

        }

        public override string HPFormula => "0.5(Lv)² + 10(Lv) + 1000";

        public override string StrengthFormula => "([5(Lv)] + [(Lv) / 4] - [(Lv)² / 300] + 45) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 20] - [(Lv)² / 500] + 40) / 4";

        public override string VitalityFormula => "8";

        public override string SpiritFormula => "5";

        public override string SpeedFormula => "((Lv) / 10) - [(Lv) / 20] + 50";

        public override string EvasionFormula => "((Lv) / 2) - [(Lv) / 4] + 10";

        public override string ExperienceFormula => "0";
    }
}