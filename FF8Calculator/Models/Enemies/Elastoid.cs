using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Elastoid : EnemyModel
    {
        public Elastoid() : base(37, "Elastoid")
        {

        }

        public override string HPFormula => "1.5(Lv)² + 30(Lv) + 500";

        public override string StrengthFormula => "([5.5(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 33) / 4";

        public override string MagicFormula => "([7(Lv)] + [(Lv) / 6] - [(Lv)² / 500] + 35) / 4";

        public override string VitalityFormula => "((Lv) / 100) + 140";

        public override string SpiritFormula => "((Lv) / 8) + 120";

        public override string SpeedFormula => "((Lv) / 8) + 120";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 12] + 4";

        public override string ExperienceFormula => "20(Lv)² + 60";
    }
}