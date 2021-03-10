using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Seifer3 : EnemyModel
    {
        public Seifer3() : base(80, "Seifer 3 (EoD2)", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "200(Lv) + 1000";

        public override string StrengthFormula => "([7.5(Lv)] + [(Lv) / 5] - [(Lv)² / 80] + 60) / 4";

        public override string MagicFormula => "([8.8(Lv)] + [(Lv) / 80] - [(Lv)² / 300] + 100) / 4";

        public override string VitalityFormula => "((Lv) / 20) - (Lv) + 2(Lv) + 80";

        public override string SpiritFormula => "((Lv) / 6) - [(Lv) / 4] + (Lv) + 130";

        public override string SpeedFormula => "(Lv) - [(Lv) / 24] + 8";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 18] + 4";

        public override string ExperienceFormula => "0";
    }
}