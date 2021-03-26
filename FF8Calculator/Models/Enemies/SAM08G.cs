using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class SAM08G : EnemyModel
    {
        public SAM08G() : base(58, "SAM08G")
        {

        }

        public override string HPFormula => "2.25(Lv)² + 45(Lv) + 700";

        public override string StrengthFormula => "([5.8(Lv)] + [(Lv) / 5] - [(Lv)² / 100] + 33) / 4";

        public override string MagicFormula => "([2.5(Lv)] + [(Lv) / 8] - [(Lv)² / 210] + 30) / 4";

        public override string VitalityFormula => "((Lv) / 4) + 25";

        public override string SpiritFormula => "((Lv) / 25) + 15";

        public override string SpeedFormula => "((Lv) / 10) - [(Lv) / 20] + 8";

        public override string EvasionFormula => "((Lv) / 7) - [(Lv) / 14]";

        public override string ExperienceFormula => "5(Lv)² + 25";
    }
}