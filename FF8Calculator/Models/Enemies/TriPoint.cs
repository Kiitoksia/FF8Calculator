using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class TriPoint : EnemyModel
    {
        public TriPoint() : base(116, "Tri-Point", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "400(Lv) + 2000";

        public override string StrengthFormula => "([8(Lv)] + [(Lv) / 2] - [(Lv)² / 260] + 12) / 4";

        public override string MagicFormula => "([10(Lv)] + [(Lv) / 4] - [(Lv)² / 500] + 8) / 4";

        public override string VitalityFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 35";

        public override string SpiritFormula => "((Lv) / 10) + 1";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 16] + 26";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}