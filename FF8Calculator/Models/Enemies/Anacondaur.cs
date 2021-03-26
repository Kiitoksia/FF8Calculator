using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Anacondaur : EnemyModel
    {
        public Anacondaur() : base(13, "Anacondaur")
        {

        }

        public override string HPFormula => "2(Lv)² + 40(Lv) + 800";

        public override string StrengthFormula => "([5(Lv)] + [(Lv) / 10] - [(Lv)² / 360] + 70) / 4";

        public override string MagicFormula => "([4.8(Lv)] + [(Lv) / 4] - [(Lv)² / 480] + 4) / 4";

        public override string VitalityFormula => "((Lv) / 2) + 10";

        public override string SpiritFormula => "((Lv) / 3) - [(Lv) / 2] + (Lv) + 1";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 10] + 10";

        public override string EvasionFormula => "((Lv) / 9) - [(Lv) / 18]";

        public override string ExperienceFormula => "10(Lv)² + 50";
    }
}