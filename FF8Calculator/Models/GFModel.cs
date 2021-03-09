using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class GFModel
    {
        public GFModel(string name, int power, int powerMod, int levelMod, Element element)
        {
            Name = name;
            Power = power;
            PowerMod = powerMod;
            LevelMod = levelMod;
            Element = Element;
        }

        public string Name { get; }
        public int Power { get; }
        public int PowerMod { get; }
        public int LevelMod { get; }
        public Element Element { get; }
    }
}
