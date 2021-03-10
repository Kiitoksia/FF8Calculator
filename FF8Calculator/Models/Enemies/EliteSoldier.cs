using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class EliteSoldier : EnemyModel
    {
        public EliteSoldier() : base(011, "Elite Soldier", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.4(Lv)² + 8(Lv)";

        public override string StrengthFormula => "([5.2(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 7) / 4";

        public override string MagicFormula => "([4.5(Lv)] + [(Lv) / 2] - [(Lv)² / 400] + 20) / 4";

        public override string VitalityFormula => "((Lv) / 8) + 36";

        public override string SpiritFormula => "((Lv) / 32) + 38";

        public override string SpeedFormula => "((Lv) / 6) - [(Lv) / 12] + 6";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 12] + 2";

        public override string ExperienceFormula => "5(Lv)² + 25";
    }
}
