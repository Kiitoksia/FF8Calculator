using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Bomb : EnemyModel
    {
        public Bomb() : base(7, "Bomb", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.4(Lv)² + 8(Lv) + 280";

        public override string StrengthFormula => "([4.1(Lv)] - [(Lv)² / 200] + 4) / 4";

        public override string MagicFormula => "([5.8(Lv)] - [(Lv)² / 200] + 1) / 4";

        public override string VitalityFormula => "((Lv) / 16) - [(Lv) / 2] + (Lv) + 1";

        public override string SpiritFormula => "((Lv) / 34) - (Lv) + 2(Lv) + 3";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 2";

        public override string EvasionFormula => "((Lv) / 11) - [(Lv) / 22]";

        public override string ExperienceFormula => "5(Lv)² + 25";
    }
}