using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Chimera : EnemyModel
    {
        public Chimera() : base(104, "Chimera", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "2.5(Lv)² + 350(Lv)";

        public override string StrengthFormula => "([7(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 80) / 4";

        public override string MagicFormula => "([8.5(Lv)] + [(Lv) / 4] - [(Lv)² / 500] + 100) / 4";

        public override string VitalityFormula => "((Lv) / 4) - [(Lv) / 3] + (Lv) + 40";

        public override string SpiritFormula => "((Lv) / 12) - [(Lv) / 6] + (Lv) + 88";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 20] + 5";

        public override string EvasionFormula => "((Lv) / 8) - [(Lv) / 16] + 2";

        public override string ExperienceFormula => "20(Lv)² + 130";
    }
}