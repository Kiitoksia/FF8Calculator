using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class UltimaWeapon : EnemyModel
    {
        public UltimaWeapon() : base(112, "Ultima Weapon")
        {

        }

        public override string HPFormula => "1100(Lv) + 50000";

        public override string StrengthFormula => "([10(Lv)] + [(Lv) / 5] - [(Lv)² / 66] + 150) / 4";

        public override string MagicFormula => "([8(Lv)] + [(Lv) / 2] - [(Lv)² / 500] + 25) / 4";

        public override string VitalityFormula => "((Lv) / 30) - [(Lv) / 4] + 2(Lv) + 10";

        public override string SpiritFormula => "((Lv) / 3) + 127";

        public override string SpeedFormula => "((Lv) / 4) - [(Lv) / 16] + (Lv) + 26";

        public override string EvasionFormula => "((Lv) / 10) - [(Lv) / 20]";

        public override string ExperienceFormula => "0";
        public override string Note => "Always Average Lvl";
    }
}