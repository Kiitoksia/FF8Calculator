using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class GIM47N : EnemyModel
    {
        public GIM47N() : base(52, "GIM47N")
        {

        }

        public override string HPFormula => "0.5(Lv)² + 10(Lv) + 300";

        public override string StrengthFormula => "([4.5(Lv)] + [(Lv) / 5] - [(Lv)² / 100] + 40) / 4";

        public override string MagicFormula => "([0.5(Lv)] + [(Lv) / 6] - [(Lv)² / 500] + 8) / 4";

        public override string VitalityFormula => "((Lv) / 16) + 40";

        public override string SpiritFormula => "((Lv) / 8) + 6";

        public override string SpeedFormula => "((Lv) / 8) - [(Lv) / 16] + 2";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 16]";

        public override string ExperienceFormula => "5(Lv)² + 25";
    }
}