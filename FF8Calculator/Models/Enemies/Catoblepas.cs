using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Catoblepas : EnemyModel
    {
        public Catoblepas() : base(122, "Catoblepas", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "500(Lv) + 10000";

        public override string StrengthFormula => "([9.5(Lv)] + [(Lv) / 3] - [(Lv)² / 400] + 20) / 4";

        public override string MagicFormula => "([7.8(Lv)] - [(Lv)² / 510] + 255) / 4";

        public override string VitalityFormula => "((Lv) / 10) - [(Lv) / 3] + (Lv) + 3";

        public override string SpiritFormula => "(((Lv) / 20) - [(Lv) / 2] + (Lv) + 1";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 16] + 26";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}