using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Turtapod : EnemyModel
    {
        public Turtapod() : base(86, "Turtapod", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.25(Lv)² + 5(Lv) + 1200";

        public override string StrengthFormula => "([3.5(Lv)] + [(Lv) / 2] - [(Lv)² / 160] + 35) / 4";

        public override string MagicFormula => "([1.5(Lv)] + [(Lv) / 10] - [(Lv)² / 300] + 20) / 4";

        public override string VitalityFormula => "((Lv) / 4) + 110";

        public override string SpiritFormula => "((Lv) / 8) + 8";

        public override string SpeedFormula => "((Lv) / 8) - [(Lv) / 16] + 10";

        public override string EvasionFormula => "((Lv) / 17) - [(Lv) / 34]";

        public override string ExperienceFormula => "10(Lv)² + 40";
    }
}