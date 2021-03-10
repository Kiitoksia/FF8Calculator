using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Imp : EnemyModel
    {
        public Imp() : base(88, "Imp", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.6(Lv)² + 12(Lv) + 4200";

        public override string StrengthFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 22) / 4";

        public override string MagicFormula => "([4.8(Lv)] + [(Lv) / 6] - [(Lv)² / 300] + 35) / 4";

        public override string VitalityFormula => "((Lv) / 4) + 8";

        public override string SpiritFormula => "((Lv) / 10) - [(Lv) / 2] + (Lv) + 120";

        public override string SpeedFormula => "(Lv) - [(Lv) / 2] + 3";

        public override string EvasionFormula => "((Lv) / 5) - [(Lv) / 20] + 30";

        public override string ExperienceFormula => "10(Lv)² + 50";
    }
}