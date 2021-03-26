using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Cerberus : EnemyModel
    {
        public Cerberus() : base(78, "Cerberus")
        {

        }

        public override string HPFormula => "100(Lv) + 7000";

        public override string StrengthFormula => "([10(Lv)] + [(Lv) / 4] - [(Lv)² / 80] + 100) / 4";

        public override string MagicFormula => "([20(Lv)] + [(Lv) / 2] - [(Lv)² / 160] + 200) / 4";

        public override string VitalityFormula => "(Lv) + 10";

        public override string SpiritFormula => "((Lv) / 2) - [(Lv) / 4] + (Lv) + 100";

        public override string SpeedFormula => "((Lv) - [(Lv) / 12] + 10";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 24] + 5";

        public override string ExperienceFormula => "0";
    }
}