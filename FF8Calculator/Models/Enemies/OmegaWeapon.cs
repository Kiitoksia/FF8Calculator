using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class OmegaWeapon : EnemyModel
    {
        public OmegaWeapon() : base(124, "Omega Weapon", new Element[] { }, new Element[] { })
        {

        }

        public override string HPFormula => "5(Lv)² + 10100(Lv) + 101000";

        public override string StrengthFormula => "([20(Lv)] + [(Lv) / 5] - [(Lv)² / 260] + 250) / 4";

        public override string MagicFormula => "([26(Lv)] - [(Lv)² / 500] + 255) / 4";

        public override string VitalityFormula => "((Lv) / 30) - [(Lv) / 2] + (Lv) + 60";

        public override string SpiritFormula => "((Lv) / 20) - [(Lv) / 2] + (Lv) + 120";

        public override string SpeedFormula => "61";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
    }
}