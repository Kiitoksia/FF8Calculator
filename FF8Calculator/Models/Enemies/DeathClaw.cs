using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class DeathClaw : EnemyModel
    {
        public DeathClaw() : base(76, "Death Claw")
        {

        }

        public override string HPFormula => "1.5(Lv)² + 30(Lv) + 4200";

        public override string StrengthFormula => "([5.3(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 40) / 4";

        public override string MagicFormula => "([4(Lv)] + [(Lv) / 4] - [(Lv)² / 200] + 40) / 4";

        public override string VitalityFormula => "((Lv) / 8) + 45";

        public override string SpiritFormula => "((Lv) / 6) + 8";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 4] + 4";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "15(Lv)² + 25";
    }
}