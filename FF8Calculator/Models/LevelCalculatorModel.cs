using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class LevelCalculatorModel : BaseModel
    {
        public int Level1 { get; set; }
        public int Level2 { get; set; }
        public int Level3 { get; set; }

        public int AverageLevel { get; set; }
        public int LowLevel { get; set; }
        public int HighLevel { get; set; }

        public void Calculate()
        {
            int partyMembersAlive = 0;
            if (Level1 > 0) partyMembersAlive++;
            if (Level2 > 0) partyMembersAlive++;
            if (Level3 > 0) partyMembersAlive++;

            if (partyMembersAlive == 0) return; // Cannot calculate
            AverageLevel = RoundDown((Level1 + Level2 + Level3) / partyMembersAlive);
            LowLevel = AverageLevel - RoundDown(AverageLevel / 5);
            HighLevel = AverageLevel + RoundDown(AverageLevel / 5);
        }
    }
}
