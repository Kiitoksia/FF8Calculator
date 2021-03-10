using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Edea2 : EnemyModel
    {
        public Edea2() : base(81, "Edea 2 (EoD2)", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "500(Lv)";

        public override string StrengthFormula => "([(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 20) / 4";

        public override string MagicFormula => "([7(Lv)] + [(Lv) / 10] - [(Lv)² / 500] + 250) / 4";

        public override string VitalityFormula => "((Lv) / 12) - [(Lv) / 4] + (Lv) + 40";

        public override string SpiritFormula => "((Lv) / 4) - [(Lv) / 2] + (Lv) + 150";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 20";

        public override string EvasionFormula => "((Lv) / 2) - [(Lv) / 4]";

        public override string ExperienceFormula => "0";
    }
}