using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Adamantoise : EnemyModel
    {
        public Adamantoise() : base(33, "Adamantoise", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "3.5(Lv)² + 70(Lv) + 500";

        public override string StrengthFormula => "([5.7(Lv)] + [(Lv) / 5] - [(Lv)² / 500] + 50) / 4";

        public override string MagicFormula => "([3.2(Lv)] + [(Lv) / 20] - [(Lv)² / 400] + 8) / 4";

        public override string VitalityFormula => "((Lv) / 200) + 210";

        public override string SpiritFormula => "((Lv) / 28) - [(Lv) / 2] + (Lv) + 150";

        public override string SpeedFormula => "((Lv) / 7) - [(Lv) / 14] + 3";

        public override string EvasionFormula => "3";

        public override string ExperienceFormula => "10(Lv)² + 40";
    }
}