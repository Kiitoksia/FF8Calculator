using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Mesmerize : EnemyModel
    {
        public Mesmerize() : base(69, "Mesmerize", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.5(Lv)² + 10(Lv) + 450";

        public override string StrengthFormula => "([3.2(Lv)] - [(Lv)² / 400] + 20) / 4";

        public override string MagicFormula => "([4.1(Lv)] - [(Lv)² / 360] + 22) / 4";

        public override string VitalityFormula => "((Lv) / 10) - [(Lv) / 2] + (Lv) + 10";

        public override string SpiritFormula => "((Lv) / 3) - [(Lv) / 2] + (Lv) + 25";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 8] + 12";

        public override string EvasionFormula => "((Lv) / 7) - [(Lv) / 14]";

        public override string ExperienceFormula => "4(Lv)² + 11";
    }
}