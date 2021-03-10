using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Raijin2 : EnemyModel
    {
        public Raijin2() : base(67, "Raijin 2", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "400(Lv)";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 110) / 4";

        public override string MagicFormula => "([4.5(Lv)] + [(Lv) / 10] - [(Lv)² / 400] + 8) / 4";

        public override string VitalityFormula => "((Lv) / 4) - [(Lv) / 2] + 2(Lv) + 40";

        public override string SpiritFormula => "((Lv) / 4) + 1";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 10] + 6";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20] + 2";

        public override string ExperienceFormula => "0";
    }
}