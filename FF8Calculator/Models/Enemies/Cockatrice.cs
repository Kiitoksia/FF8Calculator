using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Cockatrice : EnemyModel
    {
        public Cockatrice() : base(26, "Cockatrice", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.35(Lv)² + 7(Lv) + 1000";

        public override string StrengthFormula => "([3.8(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 35) / 4";

        public override string MagicFormula => "([7.7(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 52) / 4";

        public override string VitalityFormula => "((Lv) / 5) - [(Lv) / 2] + (Lv) + 8";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 3] + (Lv) + 90";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 6] + 12";

        public override string EvasionFormula => "((Lv) / 4) - [(Lv) / 12] + 2";

        public override string ExperienceFormula => "10(Lv)² + 30";
    }
}