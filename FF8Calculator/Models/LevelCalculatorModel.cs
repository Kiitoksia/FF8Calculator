using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class LevelCalculatorModel : BaseModel
    {
        private int averageLevel;
        private int highLevel;
        private int level1;
        private int level2;
        private int level3;
        private int lowLevel;

        public LevelCalculatorModel()
        {
            PropertyChanged += (s, e) => Calculate();
        }

        public int AverageLevel
        {
            get => averageLevel; 
            private set
            {
                if (averageLevel == value)
                    return;
                averageLevel = value;
                OnPropertyChanged();
            }
        }
        public int HighLevel
        {
            get => highLevel; 
            private set
            {
                if (highLevel == value)
                    return;
                highLevel = value;
                OnPropertyChanged();
            }
        }


        public int Level1
        {
            get => level1; 
            set
            {
                if (level1 == value)
                    return;
                level1 = value;
                OnPropertyChanged();
            }
        }
        public int Level2
        {
            get => level2; 
            set
            {
                if (level2 == value)
                    return;
                level2 = value;
                OnPropertyChanged();
            }
        }
        public int Level3
        {
            get => level3; 
            set
            {
                if (level3 == value)
                    return;
                level3 = value;
                OnPropertyChanged();
            }
        }
        public int LowLevel
        {
            get => lowLevel; 
            private set
            {
                if (lowLevel == value)
                    return;
                lowLevel = value;
                OnPropertyChanged();
            }
        }

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
