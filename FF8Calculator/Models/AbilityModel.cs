using System;
using System.Linq;

namespace FF8Calculator.Models
{
    public class AbilityModel : BaseModel
    {

        public AbilityModel(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name { get; }

        public int Power { get; }

    }
}
