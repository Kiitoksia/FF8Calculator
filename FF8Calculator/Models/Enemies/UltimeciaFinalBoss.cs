using FF8Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class UltimeciaFinalBoss : EnemyModel, IUltimecia
    {
        public UltimeciaFinalBoss() : base(128, "Ultimecia (Final Boss)")
        {

        }

        public override string HPFormula => "4100(Lv) + 12400";

        public override string StrengthFormula => "([3.5(Lv)] + [(Lv) / 4] - [(Lv)² / 400] + 100) / 4";

        public override string MagicFormula => "([9(Lv)] + [(Lv) / 10] - [(Lv)² / 300] + 90) / 4";

        public override string VitalityFormula => "(Lv) + 1";

        public override string SpiritFormula => "((Lv) / 50) - [(Lv) / 2] + (Lv) + 3";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 16] + 85";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}