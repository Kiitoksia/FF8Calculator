using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Gerogero : EnemyModel
    {
        public Gerogero() : base(24, "Gerogero")
        {

        }

        public override string HPFormula => "300(Lv) + 50";

        public override string StrengthFormula => "([2.5(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 140) / 4";

        public override string MagicFormula => "([6(Lv)] + [(Lv) / 6] - [(Lv)² / 200] + 240) / 4";

        public override string VitalityFormula => "2(Lv) + 15";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 25";

        public override string SpeedFormula => "((Lv) / 8) - [(Lv) / 16] + (Lv) + 8";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20] + 5";

        public override string ExperienceFormula => "0";
    }
}