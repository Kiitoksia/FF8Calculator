using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Elnoyle : EnemyModel
    {
        public Elnoyle() : base(90, "Elnoyle", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "(Lv)² + 420(Lv) + 30000";

        public override string StrengthFormula => "([7.8(Lv)] + [(Lv) / 80] - [(Lv)² / 400] + 250) / 4";

        public override string MagicFormula => "([7.7(Lv)] + [(Lv) / 200] - [(Lv)² / 500] + 250) / 4";

        public override string VitalityFormula => "((Lv) / 15) - [(Lv) / 3] + (Lv) + 10";

        public override string SpiritFormula => "(Lv) + 80";

        public override string SpeedFormula => "((Lv) / 8) - [(Lv) / 16] + 10";

        public override string EvasionFormula => "((Lv) / 18) - [(Lv) / 36]";

        public override string ExperienceFormula => "20(Lv)² + 200";
    }
}