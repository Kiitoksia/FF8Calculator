using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Grat : EnemyModel
    {
        public Grat() : base(18, "Grat")
        {

        }

        public override string HPFormula => "0.45(Lv)² + 9(Lv) + 200";

        public override string StrengthFormula => "([4.4(Lv)] + [(Lv) / 2] - [(Lv)² / 400] + 8) / 4";

        public override string MagicFormula => "([4.4(Lv)] + [(Lv) / 4] - [(Lv)² / 340] + 4) / 4";

        public override string VitalityFormula => "((Lv) / 16) + 3";

        public override string SpiritFormula => "((Lv) / 10) + 8";

        public override string SpeedFormula => "((Lv) / 6) - [(Lv) / 12] + 8";

        public override string EvasionFormula => "((Lv) / 11) - [(Lv) / 22]";

        public override string ExperienceFormula => "10(Lv)² + 28";
    }
}