using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class BGH251F21 : EnemyModel
    {
        public BGH251F21() : base(59, "BGH251F2 1", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "200(Lv) + 4000";

        public override string StrengthFormula => "([10(Lv)] + [(Lv) / 5] - [(Lv)² / 68] + 150) / 4";

        public override string MagicFormula => "([7.5(Lv)] + [(Lv) / 10] - [(Lv)² / 200] + 255) / 4";

        public override string VitalityFormula => "((Lv) / 25) - [(Lv) / 2] + 2(Lv) + 50";

        public override string SpiritFormula => "((Lv) / 8) + 130";

        public override string SpeedFormula => "7";

        public override string EvasionFormula => "((Lv) / 4) - [(Lv) / 8]";

        public override string ExperienceFormula => "40(Lv)² + 90";
    }
}