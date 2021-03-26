using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class TriFace : EnemyModel
    {
        public TriFace() : base(60, "Tri-Face")
        {

        }

        public override string HPFormula => "1.3(Lv)² + 26(Lv) + 6000";

        public override string StrengthFormula => "([6(Lv)] + [(Lv) / 2] - [(Lv)² / 200] + 60) / 4";

        public override string MagicFormula => "([10(Lv)] + [(Lv) / 3] - [(Lv)² / 200] + 32) / 4";

        public override string VitalityFormula => "((Lv) / 24) - [(Lv) / 2] + (Lv) + 40";

        public override string SpiritFormula => "((Lv) / 18) + 20";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 4] + 5";

        public override string EvasionFormula => "((Lv) / 11) - [(Lv) / 22]";

        public override string ExperienceFormula => "40(Lv)² + 90";
    }
}