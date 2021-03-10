using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Torama : EnemyModel
    {
        public Torama() : base(87, "Torama", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "(Lv)² + 220(Lv)";

        public override string StrengthFormula => "([4(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 40) / 4";

        public override string MagicFormula => "([7(Lv)] + [(Lv) / 50] - [(Lv)² / 500] + 250) / 4";

        public override string VitalityFormula => "((Lv) / 8) - [(Lv) / 2] + (Lv) + 38";

        public override string SpiritFormula => "((Lv) / 12) - [(Lv) / 2] + (Lv) + 110";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 10";

        public override string EvasionFormula => "((Lv) / 2) - [(Lv) / 4] + 10";

        public override string ExperienceFormula => "10(Lv)² + 90";
    }
}