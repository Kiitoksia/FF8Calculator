using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Minotaur : EnemyModel
    {
        public Minotaur() : base(45, "Minotaur")
        {

        }

        public override string HPFormula => "5(Lv)² + 100(Lv) + 750";

        public override string StrengthFormula => "([10(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 40) / 4";

        public override string MagicFormula => "([4.8(Lv)] + [(Lv) / 2] - [(Lv)² / 320] + 140) / 4";

        public override string VitalityFormula => "((Lv) / 8) + 60";

        public override string SpiritFormula => "((Lv) / 20) - (Lv) + 2(Lv) + 30";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 16] + 10";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 24]";

        public override string ExperienceFormula => "0";
    }
}