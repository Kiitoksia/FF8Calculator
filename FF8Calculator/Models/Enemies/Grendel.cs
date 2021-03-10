using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Grendel : EnemyModel
    {
        public Grendel() : base(29, "Grendel", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "1.5(Lv)² + 130(Lv) + 2000";

        public override string StrengthFormula => "([8.4(Lv)] + [(Lv) / 18] - [(Lv)² / 480] + 80) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 40] - [(Lv)² / 200] + 200) / 4";

        public override string VitalityFormula => "((Lv) / 10) - [(Lv) / 3] + (Lv) + 50";

        public override string SpiritFormula => "((Lv) / 18) - [(Lv) / 3] + (Lv) + 120";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 10] + 10";

        public override string EvasionFormula => "((Lv) / 7) - [(Lv) / 14] + 2";

        public override string ExperienceFormula => "15(Lv)² + 65";
    }
}