using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Griever : EnemyModel
    {
        public Griever() : base(126, "Griever", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "1550(Lv) + 15200";

        public override string StrengthFormula => "([5.5(Lv)] + [(Lv) / 5] - [(Lv)² / 400] + 110) / 4";

        public override string MagicFormula => "([21(Lv)] - [(Lv)² / 20] + 200) / 4";

        public override string VitalityFormula => "((Lv) / 5) - [(Lv) / 2] + 2(Lv) + 20";

        public override string SpiritFormula => "((Lv) / 30) - [(Lv) / 2] + (Lv) + 18";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 20] + 95";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}