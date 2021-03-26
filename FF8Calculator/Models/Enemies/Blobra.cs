using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Blobra : EnemyModel
    {
        public Blobra() : base(42, "Blobra")
        {

        }

        public override string HPFormula => "0.3(Lv)² + 6(Lv) + 240";

        public override string StrengthFormula => "([2.8(Lv)] + [(Lv) / 5] - [(Lv)² / 300] + 30) / 4";

        public override string MagicFormula => "([5.5(Lv)] + [(Lv) / 2] - [(Lv)² / 500] + 33) / 4";

        public override string VitalityFormula => "((Lv) / 20) + 240";

        public override string SpiritFormula => "((Lv) / 9) + 170";

        public override string SpeedFormula => "((Lv) / 14) - [(Lv) / 28] + 6";

        public override string EvasionFormula => "((Lv) / 5) - [(Lv) / 10]";

        public override string ExperienceFormula => "8(Lv)² + 32";
    }
}