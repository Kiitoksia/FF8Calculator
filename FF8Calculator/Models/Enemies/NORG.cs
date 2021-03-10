using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class NORG : EnemyModel
    {
        public NORG() : base(65, "NORG", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "300(Lv) + 4100";

        public override string StrengthFormula => "([10(Lv)] + [(Lv) / 4] - [(Lv)² / 300] + 60) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 4] - [(Lv)² / 500] + 200) / 4";

        public override string VitalityFormula => "((Lv) / 6) + 4";

        public override string SpiritFormula => "((Lv) / 80) - [(Lv) / 4] + (Lv) + 10";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 16] + 5";

        public override string EvasionFormula => "((Lv) / 4) - [(Lv) / 8]";

        public override string ExperienceFormula => "0";
    }
}