using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Armadodo : EnemyModel
    {
        public Armadodo() : base(41, "Armadodo", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "1.5(Lv)² + 30(Lv) + 700";

        public override string StrengthFormula => "([4.2(Lv)] + [(Lv) / 2] - [(Lv)² / 200] + 45) / 4";

        public override string MagicFormula => "([3.5(Lv)] + [(Lv) / 8] - [(Lv)² / 200] + 4) / 4";

        public override string VitalityFormula => "((Lv) / 12) + 120";

        public override string SpiritFormula => "((Lv) / 8) + 4";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 10] + 4";

        public override string EvasionFormula => "((Lv) / 12) - [(Lv) / 24]";

        public override string ExperienceFormula => "15(Lv)² + 65";
    }
}