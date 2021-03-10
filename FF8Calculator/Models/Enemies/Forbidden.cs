using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Forbidden : EnemyModel
    {
        public Forbidden() : base(43, "Forbidden", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "(Lv)² + 120(Lv) + 100";

        public override string StrengthFormula => "([6(Lv)] + [(Lv) / 4] - [(Lv)² / 500] + 50) / 4";

        public override string MagicFormula => "([5.3(Lv)] + [(Lv) / 5] - [(Lv)² / 500] + 2) / 4";

        public override string VitalityFormula => "((Lv) / 8) + 25";

        public override string SpiritFormula => "((Lv) / 8) + 200";

        public override string SpeedFormula => "(Lv) - [(Lv) / 2] + 10";

        public override string EvasionFormula => "((Lv) / 4) - [(Lv) / 12] + 2";

        public override string ExperienceFormula => "15(Lv)² + 70";
    }
}