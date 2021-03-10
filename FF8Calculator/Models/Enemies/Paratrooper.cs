using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Paratrooper : EnemyModel
    {
        public Paratrooper() : base(73, "Paratrooper", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.35(Lv)² + 7(Lv) + 600";

        public override string StrengthFormula => "([7(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 40) / 4";

        public override string MagicFormula => "([7.5(Lv)] + [(Lv) / 2] - [(Lv)² / 400] + 40) / 4";

        public override string VitalityFormula => "((Lv) / 8) + 36";

        public override string SpiritFormula => "((Lv) / 32) + 45";

        public override string SpeedFormula => "((Lv) / 6) - [(Lv) / 12] + 11";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 18] + 5";

        public override string ExperienceFormula => "5(Lv)² + 25";
    }
}