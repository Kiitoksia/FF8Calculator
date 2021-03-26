using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Gargantua : EnemyModel
    {
        public Gargantua() : base(121, "Gargantua")
        {

        }

        public override string HPFormula => "100(Lv) + 10000";

        public override string StrengthFormula => "([6.5(Lv)] + [(Lv) / 80] - [(Lv)² / 400] + 100) / 4";

        public override string MagicFormula => "([15(Lv)] + [(Lv) / 7] - [(Lv)² / 16] + 5) / 4";

        public override string VitalityFormula => "180";

        public override string SpiritFormula => "0";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 16] + 26";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}