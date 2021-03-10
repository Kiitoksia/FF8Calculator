using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Funguar : EnemyModel
    {
        public Funguar() : base(22, "Funguar", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.15(Lv)² + 3(Lv) + 300";

        public override string StrengthFormula => "([2.6(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 18) / 4";

        public override string MagicFormula => "([3(Lv)] + [(Lv) / 5] - [(Lv)² / 300] + 3) / 4";

        public override string VitalityFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 1";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 1";

        public override string SpeedFormula => "((Lv) / 8) - [(Lv) / 16] + 2";

        public override string EvasionFormula => "((Lv) / 12) - [(Lv) / 24]";

        public override string ExperienceFormula => "3(Lv)² + 17";
    }
}