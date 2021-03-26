using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class JumboCactuar : EnemyModel
    {
        public JumboCactuar() : base(110, "Jumbo Cactuar")
        {

        }

        public override string HPFormula => "3000(Lv) + 30000";

        public override string StrengthFormula => "([6(Lv)] + [(Lv) / 4] - [(Lv)² / 160] + 80) / 4";

        public override string MagicFormula => "([4.5(Lv)] + [(Lv) / 6] - [(Lv)² / 500] + 48) / 4";

        public override string VitalityFormula => "((Lv) / 15) - [(Lv) / 2] + (Lv) + 25";

        public override string SpiritFormula => "((Lv) / 2) - [(Lv) / 5] + (Lv) + 12";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 5";

        public override string EvasionFormula => "((Lv) / 16) - [(Lv) / 32]";

        public override string ExperienceFormula => "0";
        public override string Note => "Always Average Lvl";
    }
}