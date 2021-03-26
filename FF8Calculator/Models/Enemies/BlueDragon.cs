using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class BlueDragon : EnemyModel
    {
        public BlueDragon() : base(72, "Blue Dragon")
        {

        }

        public override string HPFormula => "1.75(Lv)² + 235(Lv)";

        public override string StrengthFormula => "([6.1(Lv)] + [(Lv) / 4] - [(Lv)² / 420] + 55) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 2] - [(Lv)² / 200] + 100) / 4";

        public override string VitalityFormula => "((Lv) / 8) - [(Lv) / 2] + (Lv) + 70";

        public override string SpiritFormula => "((Lv) / 2) + 120";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 4] + 5";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 16]";

        public override string ExperienceFormula => "20(Lv)² + 80";
    }
}