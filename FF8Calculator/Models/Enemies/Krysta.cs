using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Krysta : EnemyModel
    {
        public Krysta() : base(117, "Krysta")
        {

        }

        public override string HPFormula => "200(Lv) + 5000";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 3] - [(Lv)² / 200] + 200) / 4";

        public override string MagicFormula => "([26(Lv)] - [(Lv)² / 500] + 255) / 4";

        public override string VitalityFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 200";

        public override string SpiritFormula => "0";

        public override string SpeedFormula => "5";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}