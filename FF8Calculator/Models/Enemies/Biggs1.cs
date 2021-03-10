using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Biggs1 : EnemyModel
    {
        public Biggs1() : base(14, "Biggs 1", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.85(Lv)² + 17(Lv) + 450";

        public override string StrengthFormula => "([5(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 21) / 4";

        public override string MagicFormula => "([3.7(Lv)] + [(Lv) / 4] - [(Lv)² / 400] + 30) / 4";

        public override string VitalityFormula => "((Lv) / 30) - [(Lv) / 3] + (Lv) + 30";

        public override string SpiritFormula => "((Lv) / 30) - [(Lv) / 2] + (Lv) + 44";

        public override string SpeedFormula => "((Lv) / 7) - [(Lv) / 14] + 6";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 12] + 2";

        public override string ExperienceFormula => "0";
    }
}