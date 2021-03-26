using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Vysage : EnemyModel
    {
        public Vysage() : base(30, "Vysage")
        {

        }

        public override string HPFormula => "1.5(Lv)² + 30(Lv) + 3000";

        public override string StrengthFormula => "([4.8(Lv)] + [(Lv) / 50] - [(Lv)² / 200] + 46) / 4";

        public override string MagicFormula => "([4(Lv)] + [(Lv) / 32] - [(Lv)² / 480] + 55) / 4";

        public override string VitalityFormula => "((Lv) / 5) + 18";

        public override string SpiritFormula => "((Lv) / 2) + 15";

        public override string SpeedFormula => "((Lv) / 6) - [(Lv) / 12] + 5";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 16]";

        public override string ExperienceFormula => "15(Lv)² + 85";
    }
}