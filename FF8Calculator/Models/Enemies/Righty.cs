using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Righty : EnemyModel
    {
        public Righty() : base(32, "Righty", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "(Lv)² + 20(Lv) + 1800";

        public override string StrengthFormula => "([5(Lv)] + [(Lv) / 2] - [(Lv)² / 500] + 44) / 4";

        public override string MagicFormula => "([(Lv)] + [(Lv) / 2] - [(Lv)² / 360] + 4) / 4";

        public override string VitalityFormula => "((Lv) / 4) + 80";

        public override string SpiritFormula => "((Lv) / 16) + 5";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 10] + 2";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "10(Lv)² + 30";
    }
}