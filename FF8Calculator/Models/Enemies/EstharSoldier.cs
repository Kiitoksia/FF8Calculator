using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class EstharSoldier : EnemyModel
    {
        public EstharSoldier() : base(34, "Esthar Soldier", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.4(Lv)² + 8(Lv) + 90";

        public override string StrengthFormula => "([3.8(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 12) / 4";

        public override string MagicFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 500] + 2) / 4";

        public override string VitalityFormula => "((Lv) / 16) + 2";

        public override string SpiritFormula => "((Lv) / 8) + 5";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 12] + 5";

        public override string EvasionFormula => "((Lv) / 4) - [(Lv) / 8]";

        public override string ExperienceFormula => "3(Lv)² + 17";
    }
}