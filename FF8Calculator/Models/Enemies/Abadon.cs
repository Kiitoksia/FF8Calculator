using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Abadon : EnemyModel
    {
        public Abadon() : base(83, "Abadon", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "500(Lv) + 10";

        public override string StrengthFormula => "([6(Lv)] + [(Lv) / 60] - [(Lv)² / 100] + 150) / 4";

        public override string MagicFormula => "([4(Lv)] + [(Lv) / 75] - [(Lv)² / 100] + 240) / 4";

        public override string VitalityFormula => "(Lv) - [(Lv) / 2] + 140";

        public override string SpiritFormula => "((Lv) / 64) - [(Lv) / 2] + (Lv) + 40";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 16] + 16";

        public override string EvasionFormula => "((Lv) / 4) - [(Lv) / 8] + 8";

        public override string ExperienceFormula => "0";
    }
}