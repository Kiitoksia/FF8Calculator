using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class BaseSoldier : EnemyModel
    {
        public BaseSoldier() : base(56, "Base Soldier")
        {

        }

        public override string HPFormula => "0.85(Lv)² + 17(Lv) + 200";

        public override string StrengthFormula => "([4.5(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 27) / 4";

        public override string MagicFormula => "([4(Lv)] + [(Lv) / 5] - [(Lv)² / 400] + 12) / 4";

        public override string VitalityFormula => "((Lv) / 30) - [(Lv) / 3] + (Lv) + 22";

        public override string SpiritFormula => "((Lv) / 30) + 32";

        public override string SpeedFormula => "((Lv) / 7) - [(Lv) / 14] + 4";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 12]";

        public override string ExperienceFormula => "5(Lv)² + 25";
    }
}