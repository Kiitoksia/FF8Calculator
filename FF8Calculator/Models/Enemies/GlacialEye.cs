using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class GlacialEye : EnemyModel
    {
        public GlacialEye() : base(002, "Glacial Eye", new Element[] { Element.Ice }, new[] { Element.Fire })
        {

        }

        public override string HPFormula => "0.25(Lv)² + 5(Lv) + 200";

        public override string StrengthFormula => "([2.8(Lv)] - [(Lv)² / 100] + 10) / 4";

        public override string MagicFormula => "([3(Lv)] + [(Lv) / 4] - [(Lv)² / 400] + 18) / 4";

        public override string VitalityFormula => "((Lv) / 3) + 12";

        public override string SpiritFormula => "((Lv) / 16) + 100";

        public override string SpeedFormula => "((Lv) / 12) - [(Lv) / 24] + 10";

        public override string EvasionFormula => "((Lv) / 15) - [(Lv) / 30]";

        public override string ExperienceFormula => "5(Lv)² + 10";
    }
}
