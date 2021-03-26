using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Diablos : EnemyModel
    {
        public Diablos() : base(21, "Diablos")
        {

        }

        public override string HPFormula => "800(Lv) + 800";

        public override string StrengthFormula => "([18(Lv)] + [(Lv) / 100] - [(Lv)² / 200] + 50) / 4";

        public override string MagicFormula => "([10(Lv)] + [(Lv) / 5] - [(Lv)² / 80] + 12) / 4";

        public override string VitalityFormula => "((Lv) / 8) - [(Lv) / 2] + (Lv) + 50";

        public override string SpiritFormula => "(Lv) - [(Lv) / 2] + (Lv) + 75";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 32] + 15";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 24]";

        public override string ExperienceFormula => "0";

        public override string Note => "Always Average Lvl";
    }
}