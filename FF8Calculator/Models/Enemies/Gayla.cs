using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Gayla : EnemyModel
    {
        public Gayla() : base(70, "Gayla", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "(Lv)² + 20(Lv) + 1000";

        public override string StrengthFormula => "([3.6(Lv)] + [(Lv) / 4] - [(Lv)² / 300] + 20) / 4";

        public override string MagicFormula => "([4.2(Lv)] + [(Lv) / 4] - [(Lv)² / 460] + 27) / 4";

        public override string VitalityFormula => "((Lv) / 2) + 15";

        public override string SpiritFormula => "((Lv) / 18) - [(Lv) / 3] + (Lv) + 33";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 4] + 10";

        public override string EvasionFormula => "((Lv) / 6) - [(Lv) / 12] + 1";

        public override string ExperienceFormula => "5(Lv)² + 25";
    }
}