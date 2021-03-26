using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Wedge1 : EnemyModel
    {
        public Wedge1() : base(15, "Wedge 1")
        {

        }

        public override string HPFormula => "0.8(Lv)² + 16(Lv) + 400";

        public override string StrengthFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 27) / 4";

        public override string MagicFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 400] + 12) / 4";

        public override string VitalityFormula => "((Lv) / 30) - [(Lv) / 3] + (Lv) + 22";

        public override string SpiritFormula => "((Lv) / 30) - [(Lv) / 2] + (Lv) + 32";

        public override string SpeedFormula => "((Lv) / 7) - [(Lv) / 14] + 5";

        public override string EvasionFormula => "((Lv) / 7) - [(Lv) / 14] + 1";

        public override string ExperienceFormula => "0";
    }
}