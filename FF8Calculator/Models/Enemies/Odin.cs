using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Odin : EnemyModel
    {
        public Odin() : base(107, "Odin")
        {

        }

        public override string HPFormula => "300(Lv) + 1000";

        public override string StrengthFormula => "([6(Lv)] + [(Lv) / 100] - [(Lv)² / 250] + 13) / 4";

        public override string MagicFormula => "([7.5(Lv)] + [(Lv) / 2] - [(Lv)² / 200] + 100) / 4";

        public override string VitalityFormula => "((Lv) / 15) - [(Lv) / 12] + (Lv) + 120";

        public override string SpiritFormula => "((Lv) / 16) - [(Lv) / 4] + (Lv) + 150";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 16] + 1";

        public override string EvasionFormula => "((Lv) / 4) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}