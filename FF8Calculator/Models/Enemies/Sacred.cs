using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Sacred : EnemyModel
    {
        public Sacred() : base(44, "Sacred")
        {

        }

        public override string HPFormula => "3.75(Lv)² + 75(Lv) + 500";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 30) / 4";

        public override string MagicFormula => "([4.8(Lv)] + [(Lv) / 2] - [(Lv)² / 320] + 100) / 4";

        public override string VitalityFormula => "((Lv) / 20) + 40";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 30";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 16] + 10";

        public override string EvasionFormula => "((Lv) / 9) - [(Lv) / 27]";

        public override string ExperienceFormula => "0";
    }
}