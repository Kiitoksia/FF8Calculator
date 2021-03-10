using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Seifer4 : EnemyModel
    {
        public Seifer4() : base(97, "Seifer 4 (EoD3)", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "700(Lv) + 3000";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 5] - [(Lv)² / 120] + 145) / 4";

        public override string MagicFormula => "([20(Lv)] - [(Lv)² / 10] + 19) / 4";

        public override string VitalityFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 100";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 120";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 16] + 46";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}