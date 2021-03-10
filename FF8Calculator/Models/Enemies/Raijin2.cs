using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Raijin3 : EnemyModel
    {
        public Raijin3() : base(92, "Raijin 2 (EoD3)", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "400(Lv) + 5000";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 110) / 4";

        public override string MagicFormula => "([4.5(Lv)] + [(Lv) / 10] - [(Lv)² / 400] + 8) / 4";

        public override string VitalityFormula => "((Lv) / 5) - [(Lv) / 3] + 2(Lv) + 50";

        public override string SpiritFormula => "(((Lv) / 4) + 1";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 6] + 30";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20] + 2";

        public override string ExperienceFormula => "0";
    }
}