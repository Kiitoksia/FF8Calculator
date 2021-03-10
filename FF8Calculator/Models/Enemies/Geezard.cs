using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Geezard : EnemyModel
    {
        public Geezard() : base(012, "Geezard", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.15(Lv)² + 3(Lv) + 40";

        public override string StrengthFormula => "([2.8(Lv)] + [(Lv) / 5] - [(Lv)² / 180] + 18) / 4";

        public override string MagicFormula => "([2.2(Lv)] + [(Lv) / 22] - [(Lv)² / 200] + 4) / 4";

        public override string VitalityFormula => "((Lv) / 32) + 4";

        public override string SpiritFormula => "((Lv) / 6) + 1";

        public override string SpeedFormula => "((Lv) / 6) - [(Lv) / 12] + 3";

        public override string EvasionFormula => "((Lv) / 7) - [(Lv) / 14]";

        public override string ExperienceFormula => "5(Lv)² + 5";
    }
}
