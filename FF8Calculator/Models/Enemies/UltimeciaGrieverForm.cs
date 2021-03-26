using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class UltimeciaGrieverForm : EnemyModel
    {
        public UltimeciaGrieverForm() : base(127, "Ultimecia (Griever Form)")
        {

        }

        public override string HPFormula => "550(Lv) + 10500";

        public override string StrengthFormula => "([6.5(Lv)] + [(Lv) / 80] - [(Lv)² / 160] + 100) / 4";

        public override string MagicFormula => "([24(Lv)] + [(Lv) / 2] - [(Lv)² / 8] + 100) / 4";

        public override string VitalityFormula => "((Lv) / 30) - [(Lv) / 2] + (Lv) + 50";

        public override string SpiritFormula => "((Lv) / 40) - [(Lv) / 3] + (Lv) + 3";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 16] + 85";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}