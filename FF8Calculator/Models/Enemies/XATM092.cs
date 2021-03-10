using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class XATM092 : EnemyModel
    {
        public XATM092() : base(17, "X-ATM092", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "2.5(Lv)² + 50(Lv) + 5020";

        public override string StrengthFormula => "([4(Lv)] + [(Lv) / 8] - [(Lv)² / 260] + 50) / 4";

        public override string MagicFormula => "([2.7(Lv)] + [(Lv) / 6] - [(Lv)² / 400] + 8) / 4";

        public override string VitalityFormula => "((Lv) / 9) + 50";

        public override string SpiritFormula => "((Lv) / 3) + 12";

        public override string SpeedFormula => "((Lv) / 7) - [(Lv) / 14] + 8";

        public override string EvasionFormula => "((Lv) / 15) - [(Lv) / 30]";

        public override string ExperienceFormula => "0";
    }
}