using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class GFDamageModel : BaseDamageModel
    {
        public GFDamageModel()
        {
            GFs.Add(new GFModel("Quezacotl", 44, 0, 60, Element.Lightning));
            GFs.Add(new GFModel("Shiva", 43, 0, 62, Element.Ice));
            GFs.Add(new GFModel("Ifrit", 45, 2, 61, Element.Fire));
            GFs.Add(new GFModel("Siren", 35, 0, 55, Element.None));
            GFs.Add(new GFModel("Brothers", 46, 4, 60, Element.Earth));
            GFs.Add(new GFModel("Leviathan", 47, 10, 63, Element.Water));
            GFs.Add(new GFModel("Pandemona", 46, 14, 65, Element.Wind));
            GFs.Add(new GFModel("Alexander", 48, 20, 63, Element.Holy));
            GFs.Add(new GFModel("Doomtrain", 45, 10, 58, Element.Poison));
            GFs.Add(new GFModel("Bahamut", 55, 30, 70, Element.NoneBypassSpirit));
            GFs.Add(new GFModel("Tonberry", 60, 4, 45, Element.None));
            GFs.Add(new GFModel("Eden", 70, 250, 100, Element.NoneBypassSpirit));
            GFs.Add(new GFModel("Phoenix", 30, 50, 254, Element.Fire));

            MultiplierModel.Create(this, "Raldo Defence Mode", 0.67m);
            MultiplierModel.Create(this, "Invulnerable", 0);
            MultiplierModel.Create(this, "Elemental Multiplier", 1.5m);
        }

        public int Level { get; set; }
        public int TargetSpirit { get; set; }
        public int Boost { get; set; }
        public List<GFModel> GFs { get; } = new List<GFModel>();
        public GFModel GF { get; set; }


        public void Calculate()
        {
            decimal damageA = RoundDown(GF.LevelMod * Level / 10 + GF.Power + GF.PowerMod);
            decimal damageB = RoundDown(damageA * (265 - TargetSpirit) / 8);
            decimal damageC = RoundDown(damageB * GF.Power / 256);
            BaseDamage = RoundDown(damageC * Boost / 100);

            CalculateBase();

        }
    }
}
