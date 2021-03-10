using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Tiamat : EnemyModel
    {
        public Tiamat() : base(123, "Tiamat", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "1200(Lv) + 20000";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 3] - [(Lv)² / 260] + 220) / 4";

        public override string MagicFormula => "([9(Lv)] + [(Lv) / 3] - [(Lv)² / 40] + 240) / 4";

        public override string VitalityFormula => "(Lv) + 80";

        public override string SpiritFormula => "((Lv) / 35) - (Lv) + 3(Lv) + 2";

        public override string SpeedFormula => "20";

        public override string EvasionFormula => "20";

        public override string ExperienceFormula => "0";
    }
}