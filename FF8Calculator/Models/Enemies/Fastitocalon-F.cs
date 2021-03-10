using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Fastitocalon : EnemyModel
    {
        public Fastitocalon() : base(004, "Fastitocalon-F", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.75(Lv)² + 15(Lv) + 200";

        public override string StrengthFormula => "([4(Lv)] + [(Lv) / 2] - [(Lv)² / 360] + 20) / 4";

        public override string MagicFormula => "([6(Lv)] + [(Lv) / 8] - [(Lv)² / 360] + 140) / 4";

        public override string VitalityFormula => "((Lv) / 3) + 40";

        public override string SpiritFormula => "((Lv) / 5) + 58";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 12] + 3";

        public override string EvasionFormula => "((Lv) / 5) - [(Lv) / 10] + 5";

        public override string ExperienceFormula => "5(Lv)² + 10";
    }
}
