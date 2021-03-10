using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Fujin1 : EnemyModel
    {
        public Fujin1() : base(68, "Fujin 1", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "300(Lv)";

        public override string StrengthFormula => "([6.5(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 60) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 2] - [(Lv)² / 500] + 25) / 4";

        public override string VitalityFormula => "((Lv) / 30) - [(Lv) / 2] + (Lv) + 5";

        public override string SpiritFormula => "((Lv) / 3) - [(Lv) / 2] + (Lv) + 120";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 4] + 15";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 18] + 10";

        public override string ExperienceFormula => "0";
    }
}