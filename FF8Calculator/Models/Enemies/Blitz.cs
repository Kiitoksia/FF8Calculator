using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Blitz : EnemyModel
    {
        public Blitz() : base(75, "Blitz")
        {

        }

        public override string HPFormula => "0.55(Lv)² + 11(Lv) + 600";

        public override string StrengthFormula => "([4(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 33) / 4";

        public override string MagicFormula => "([(Lv)] + [(Lv) / 24] - [(Lv)² / 500] + 230) / 4";

        public override string VitalityFormula => "((Lv) / 24) + 35";

        public override string SpiritFormula => "((Lv) / 16) + 25";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 12] + 2";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "10(Lv)² + 10";
    }
}