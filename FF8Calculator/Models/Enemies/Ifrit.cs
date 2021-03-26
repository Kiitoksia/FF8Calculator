using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Ifrit : EnemyModel
    {
        public Ifrit() : base(9, "Ifrit")
        {

        }

        public override string HPFormula => "3(Lv)² + 60(Lv) + 600";

        public override string StrengthFormula => "([2.8(Lv)] + [(Lv) / 2] - [(Lv)² / 200] + 130) / 4";

        public override string MagicFormula => "([2(Lv)] + [(Lv) / 4] - [(Lv)² / 400] + 26) / 4";

        public override string VitalityFormula => "((Lv) / 5) - [(Lv) / 2] + (Lv) + 40";

        public override string SpiritFormula => "((Lv) / 11) - [(Lv) / 2] + (Lv) + 180";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 10] + 2";

        public override string EvasionFormula => "((Lv) / 11) - [(Lv) / 33]";

        public override string ExperienceFormula => "0";
    }
}