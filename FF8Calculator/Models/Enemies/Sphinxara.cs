using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Sphinxara : EnemyModel
    {
        public Sphinxara() : base(115, "Sphinxara")
        {

        }

        public override string HPFormula => "10000";

        public override string StrengthFormula => "([6(Lv)] + [(Lv) / 5] - [(Lv)² / 300] + 12) / 4";

        public override string MagicFormula => "([4(Lv)] + [(Lv) / 60] - [(Lv)² / 500] + 10) / 4";

        public override string VitalityFormula => "((Lv) / 15) + 8";

        public override string SpiritFormula => "((Lv) / 4) - [(Lv) / 3] + (Lv) + 60";

        public override string SpeedFormula => "(((Lv) / 2) - [(Lv) / 8] + 4";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}