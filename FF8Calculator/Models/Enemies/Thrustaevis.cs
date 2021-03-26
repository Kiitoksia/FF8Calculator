using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Thrustaevis : EnemyModel
    {
        public Thrustaevis() : base(25, "Thrustaevis")
        {

        }

        public override string HPFormula => "0.5(Lv)² + 10(Lv) + 300";

        public override string StrengthFormula => "([3.8(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 30) / 4";

        public override string MagicFormula => "([1.2(Lv)] + [(Lv) / 6] - [(Lv)² / 200] + 4) / 4";

        public override string VitalityFormula => "((Lv) / 32) - [(Lv) / 2] + (Lv) + 5";

        public override string SpiritFormula => "((Lv) / 16) + 12";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 15] + 20";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 12] + 20";

        public override string ExperienceFormula => "8(Lv)² + 12";
    }
}