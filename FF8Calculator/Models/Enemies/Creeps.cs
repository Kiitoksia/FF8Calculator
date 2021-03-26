using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Creeps : EnemyModel
    {
        public Creeps() : base(46, "Creeps")
        {

        }

        public override string HPFormula => "0.5(Lv)² + 10(Lv) + 200";

        public override string StrengthFormula => "([2.5(Lv)] + [(Lv) / 2] - [(Lv)² / 400] + 24) / 4";

        public override string MagicFormula => "([4(Lv)] + [(Lv) / 20] - [(Lv)² / 400] + 24) / 4";

        public override string VitalityFormula => "((Lv) / 18) + 3";

        public override string SpiritFormula => "((Lv) / 128) - [(Lv) / 2] + (Lv) + 170";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 25";

        public override string EvasionFormula => "((Lv) / 5) - [(Lv) / 10] + 30";

        public override string ExperienceFormula => "8(Lv)² + 27";
    }
}