using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Granaldo : EnemyModel
    {
        public Granaldo() : base(19, "Granaldo")
        {

        }

        public override string HPFormula => "0.7(Lv)² + 14(Lv) + 1300";

        public override string StrengthFormula => "([4.7(Lv)] + [(Lv) / 2] - [(Lv)² / 200] + 5) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 6] - [(Lv)² / 150] + 2) / 4";

        public override string VitalityFormula => "((Lv) / 2) - (Lv) + 3(Lv) + 1";

        public override string SpiritFormula => "((Lv) / 8) - (Lv) + 3(Lv) + 1";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 10";

        public override string EvasionFormula => "((Lv) / 3) - [(Lv) / 6]";

        public override string ExperienceFormula => "10(Lv)² + 30";
    }
}