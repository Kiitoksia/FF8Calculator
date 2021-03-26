using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class SorceressB : EnemyModel
    {
        public SorceressB() : base(101, "SorceressB")
        {

        }

        public override string HPFormula => "0.85(Lv)² + 17(Lv) + 2010";

        public override string StrengthFormula => "([7(Lv)] + [(Lv) / 4] - [(Lv)² / 500] + 70) / 4";

        public override string MagicFormula => "([19(Lv)] + [(Lv) / 3] - [(Lv)² / 12] + 5) / 4";

        public override string VitalityFormula => "10";

        public override string SpiritFormula => "1";

        public override string SpeedFormula => "40";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}