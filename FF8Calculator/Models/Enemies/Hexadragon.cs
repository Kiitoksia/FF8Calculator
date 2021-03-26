using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Hexadragon : EnemyModel
    {
        public Hexadragon() : base(105, "Hexadragon")
        {

        }

        public override string HPFormula => "2.5(Lv)² + 50(Lv) + 10000";

        public override string StrengthFormula => "([8(Lv)] - [(Lv)² / 360] + 200) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 20] - [(Lv)² / 300] + 180) / 4";

        public override string VitalityFormula => "((Lv) / 14) - [(Lv) / 2] + (Lv) + 70";

        public override string SpiritFormula => "((Lv) / 30) - [(Lv) / 3] + (Lv) + 50";

        public override string SpeedFormula => "((Lv) / 6) - [(Lv) / 12] + 10";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "30(Lv)² + 210";
    }
}