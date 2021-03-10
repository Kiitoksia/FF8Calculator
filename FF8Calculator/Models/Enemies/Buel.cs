using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Buel : EnemyModel
    {
        public Buel() : base(8, "Buel", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.15(Lv)² + 3(Lv) + 40";

        public override string StrengthFormula => "([2(Lv)] + [(Lv) / 64] - [(Lv)² / 300] + 4) / 4";

        public override string MagicFormula => "([8.8(Lv)] + [(Lv) / 2] - [(Lv)² / 400] + 4) / 4";

        public override string VitalityFormula => "((Lv) / 16) + 1";

        public override string SpiritFormula => "((Lv) / 8) + 200";

        public override string SpeedFormula => "((Lv) / 7) - [(Lv) / 14] + 10";

        public override string EvasionFormula => "((Lv) / 14) - [(Lv) / 28]";

        public override string ExperienceFormula => "(Lv)² + 4";
    }
}