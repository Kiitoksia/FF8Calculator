using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Belhelmel : EnemyModel
    {
        public Belhelmel() : base(39, "Belhelmel")
        {

        }

        public override string HPFormula => "0.45(Lv)² + 9(Lv) + 360";

        public override string StrengthFormula => "([4.4(Lv)] - [(Lv)² / 360] + 14) / 4";

        public override string MagicFormula => "([3.8(Lv)] + [(Lv) / 20] - [(Lv)² / 500] + 18) / 4";

        public override string VitalityFormula => "((Lv) / 32) + 30";

        public override string SpiritFormula => "((Lv) / 8) + 10";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 6] + 10";

        public override string EvasionFormula => "((Lv) / 11) - [(Lv) / 22]";

        public override string ExperienceFormula => "6(Lv)² + 4";
    }
}