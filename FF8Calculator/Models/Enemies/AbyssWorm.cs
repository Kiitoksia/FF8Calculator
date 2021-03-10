using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class AbyssWorm : EnemyModel
    {
        public AbyssWorm() : base(103, "Abyss Worm", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.5(Lv)² + 210(Lv)";

        public override string StrengthFormula => "([5.8(Lv)] - [(Lv)² / 260] + 40) / 4";

        public override string MagicFormula => "([2.5(Lv)] + [(Lv) / 16] - [(Lv)² / 300] + 13) / 4";

        public override string VitalityFormula => "((Lv) / 8) - [(Lv) / 2] + (Lv) + 1";

        public override string SpiritFormula => "((Lv) / 8) + 8";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 8] + 3";

        public override string EvasionFormula => "((Lv) / 12) - [(Lv) / 24]";

        public override string ExperienceFormula => "10(Lv)² + 90";
    }
}