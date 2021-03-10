using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Iguion : EnemyModel
    {
        public Iguion() : base(48, "Iguion", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "2.25(Lv)² + 45(Lv) + 80";

        public override string StrengthFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 55) / 4";

        public override string MagicFormula => "([3(Lv)] + [(Lv) / 15] - [(Lv)² / 160] + 38) / 4";

        public override string VitalityFormula => "((Lv) / 25) - (Lv) + 3(Lv) + 50";

        public override string SpiritFormula => "((Lv) / 2) + 10";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 15] + 3";

        public override string EvasionFormula => "((Lv) / 14) - [(Lv) / 28]";

        public override string ExperienceFormula => "0";
    }
}