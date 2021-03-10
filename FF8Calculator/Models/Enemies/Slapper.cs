using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Slapper : EnemyModel
    {
        public Slapper() : base(77, "Slapper", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "10.7(Lv)² + 14(Lv) + 30";

        public override string StrengthFormula => "([5.2(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 30) / 4";

        public override string MagicFormula => "([5(Lv)] + [(Lv) / 2] - [(Lv)² / 400] + 25) / 4";

        public override string VitalityFormula => "((Lv) / 8) + 36";

        public override string SpiritFormula => "((Lv) / 32) + 40";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 20] + 20";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 18] + 20";

        public override string ExperienceFormula => "10(Lv)² + 30";
    }
}