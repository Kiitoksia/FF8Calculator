using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Caterchipillar : EnemyModel
    {
        public Caterchipillar() : base(3, "Caterchipillar")
        {

        }

        public override string HPFormula => "0.6(Lv)² + 12(Lv) + 160";

        public override string StrengthFormula => "([3.6(Lv)] - [(Lv)² / 300] + 40) / 4";

        public override string MagicFormula => "([7(Lv)] - [(Lv)² / 400] + 24) / 4";

        public override string VitalityFormula => "((Lv) / 32) - [(Lv) / 3] + (Lv) + 1";

        public override string SpiritFormula => "((Lv) / 20) + 18";

        public override string SpeedFormula => "((Lv) / 7) - [(Lv) / 14] + 4";

        public override string EvasionFormula => "((Lv) / 14) - [(Lv) / 28]";

        public override string ExperienceFormula => "5(Lv)² + 23";
    }
}