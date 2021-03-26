using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Cactuar : EnemyModel
    {
        public Cactuar() : base(109, "Cactuar")
        {

        }

        public override string HPFormula => "0.1(Lv)² + 2(Lv) + 200";

        public override string StrengthFormula => "([1.5(Lv)] - [(Lv)² / 200] + 8) / 4";

        public override string MagicFormula => "([5.5(Lv)] + [(Lv) / 3] - [(Lv)² / 160] + 18) / 4";

        public override string VitalityFormula => "((Lv) / 4) - [(Lv) / 2] + 2(Lv) + 14";

        public override string SpiritFormula => "((Lv) / 240) + 254";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 8";

        public override string EvasionFormula => "100";

        public override string ExperienceFormula => "(Lv)²";
    }
}