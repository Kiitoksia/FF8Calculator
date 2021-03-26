using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Jelleye : EnemyModel
    {
        public Jelleye() : base(74, "Jelleye")
        {

        }

        public override string HPFormula => "0.5(Lv)² + 10(Lv) + 500";

        public override string StrengthFormula => "([2(Lv)] + [(Lv) / 3] - [(Lv)² / 360] + 20) / 4";

        public override string MagicFormula => "([7.5(Lv)] + [(Lv) / 4] - [(Lv)² / 500] + 80) / 4";

        public override string VitalityFormula => "((Lv) / 3) + 6";

        public override string SpiritFormula => "((Lv) / 2) + 80";

        public override string SpeedFormula => "((Lv) / 8) - [(Lv) / 16] + 10";

        public override string EvasionFormula => "((Lv) / 11) - [(Lv) / 22]";

        public override string ExperienceFormula => "5(Lv)² + 25";
    }
}