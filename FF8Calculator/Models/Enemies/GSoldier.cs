using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class GSoldier : EnemyModel
    {
        public GSoldier() : base(010, "G-Soldier", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.25(Lv)² + 5(Lv) + 40";

        public override string StrengthFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 12) / 4";

        public override string MagicFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 500] + 2) / 4";

        public override string VitalityFormula => "((Lv) / 8) + 1";

        public override string SpiritFormula => "((Lv) / 8) + 2";

        public override string SpeedFormula => "((Lv) / 7) - [(Lv) / 14] + 4";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 12]";

        public override string ExperienceFormula => "3(Lv)² + 17";
    }
}
