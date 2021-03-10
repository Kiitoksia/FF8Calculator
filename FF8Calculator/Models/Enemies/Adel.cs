using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Adel : EnemyModel
    {
        public Adel() : base(98, "Adel", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "1000(Lv) + 5000";

        public override string StrengthFormula => "([7.5(Lv)] + [(Lv) / 5] - [(Lv)² / 200] + 180) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 2] - [(Lv)² / 72] + 230) / 4";

        public override string VitalityFormula => "((Lv) / 4) - [(Lv) / 2] + 2(Lv) + 30";

        public override string SpiritFormula => "((Lv) / 10) - [(Lv) / 100] + 2(Lv) + 40";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 16] + 35";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}