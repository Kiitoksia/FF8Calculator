using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class EstharSoldierTerminator : EnemyModel
    {
        public EstharSoldierTerminator() : base(35, "Esthar Soldier (Terminator)")
        {

        }

        public override string HPFormula => "0.65(Lv)² + 13(Lv) + 150";

        public override string StrengthFormula => "([5.5(Lv)] + [(Lv) / 5] - [(Lv)² / 280] + 30) / 4";

        public override string MagicFormula => "([4.8(Lv)] + [(Lv) / 2] - [(Lv)² / 400] + 20) / 4";

        public override string VitalityFormula => "((Lv) / 32) + 44";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 30";

        public override string SpeedFormula => "((Lv) / 2) - [(Lv) / 10] + 6";

        public override string EvasionFormula => "((Lv) / 9) - [(Lv) / 18]";

        public override string ExperienceFormula => "3(Lv)² + 27";
    }
}