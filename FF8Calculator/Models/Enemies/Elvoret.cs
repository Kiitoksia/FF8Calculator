using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Elvoret : EnemyModel
    {
        public Elvoret() : base(16, "Elvoret", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "3(Lv)² + 160(Lv) + 1400";

        public override string StrengthFormula => "([4.2(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 65) / 4";

        public override string MagicFormula => "([7(Lv)] + [(Lv) / 5] - [(Lv)² / 500] + 36) / 4";

        public override string VitalityFormula => "((Lv) / 5) + 2";

        public override string SpiritFormula => "((Lv) / 3) + 127";

        public override string SpeedFormula => "((Lv) / 5) - [(Lv) / 40] + 8";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 12]";

        public override string ExperienceFormula => "0";
    }
}