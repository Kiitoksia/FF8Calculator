using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Tonberry : EnemyModel
    {
        public Tonberry() : base(106, "Tonberry")
        {

        }

        public override string HPFormula => "200(Lv) + 15000";

        public override string StrengthFormula => "([7.5(Lv)] + [(Lv) / 8] - [(Lv)² / 260] + 70) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 10] - [(Lv)² / 280] + 25) / 4";

        public override string VitalityFormula => "((Lv) / 4) - [(Lv) / 2] + 2(Lv) + 30";

        public override string SpiritFormula => "((Lv) / 4) - [(Lv) / 2] + 2(Lv) + 35";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 4] + 12";

        public override string EvasionFormula => "1";

        public override string ExperienceFormula => "0";
        public override string Note => "Always Average Lvl";
    }
}