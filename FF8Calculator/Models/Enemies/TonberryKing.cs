using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class TonberryKing : EnemyModel
    {
        public TonberryKing() : base(108, "Tonberry King")
        {

        }

        public override string HPFormula => "2500(Lv)";

        public override string StrengthFormula => "([8.5(Lv)] + [(Lv) / 2] - [(Lv)² / 200] + 20) / 4";

        public override string MagicFormula => "([9(Lv)] + [(Lv) / 12] - [(Lv)² / 80] + 75) / 4";

        public override string VitalityFormula => "((Lv) / 4) - [(Lv) / 2] + (Lv) + 80";

        public override string SpiritFormula => "((Lv) / 4) + 20";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 4] + 2";

        public override string EvasionFormula => "((Lv) / 15) - [(Lv) / 30]";

        public override string ExperienceFormula => "0";
        public override string Note => "Always Average Lvl";
    }
}