using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Raldo : EnemyModel
    {
        public Raldo() : base(20, "Raldo", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "0.55(Lv)² + 11(Lv) + 100";

        public override string StrengthFormula => "([3(Lv)] - [(Lv)² / 88] + 5) / 4";

        public override string MagicFormula => "([8.5(Lv)] + [(Lv) / 6] - [(Lv)² / 500] + 2) / 4";

        public override string VitalityFormula => "((Lv) / 2) - [(Lv) / 8] + 2(Lv) + 30";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 8] + 2(Lv) + 55";

        public override string SpeedFormula => "((Lv) / 3) - [(Lv) / 6] + 30";

        public override string EvasionFormula => "((Lv) / 16) - [(Lv) / 32]";

        public override string ExperienceFormula => "10(Lv)² + 30";
    }
}