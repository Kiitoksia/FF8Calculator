using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Malboro : EnemyModel
    {
        public Malboro() : base(84, "Malboro", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.5(Lv)² + 1410(Lv)";

        public override string StrengthFormula => "([5.5(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 100) / 4";

        public override string MagicFormula => "([10(Lv)] + [(Lv) / 6] - [(Lv)² / 500] + 8) / 4";

        public override string VitalityFormula => "((Lv) / 8) + 10";

        public override string SpiritFormula => "((Lv) / 8) + 8";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 15] + 4";

        public override string EvasionFormula => "((Lv) / 9) - [(Lv) / 18]";

        public override string ExperienceFormula => "40(Lv)² + 180";
    }
}