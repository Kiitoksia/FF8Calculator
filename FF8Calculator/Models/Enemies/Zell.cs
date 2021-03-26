using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Zell : EnemyModel
    {
        public Zell() : base(181, "Zell")
        {
            PopulateStats();
        }


        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(08, 0544, 19, 05, 06, 04, 21, 15));
            FixedStats.Add(new StatModel(09, 0585, 20, 06, 06, 04, 21, 15));
            FixedStats.Add(new StatModel(10, 0627, 21, 07, 07, 05, 22, 15));
            FixedStats.Add(new StatModel(11, 0668, 21, 07, 08, 05, 22, 15));
            FixedStats.Add(new StatModel(12, 0709, 22, 08, 09, 06, 22, 15));
            FixedStats.Add(new StatModel(13, 0750, 23, 08, 09, 06, 22, 15));
            FixedStats.Add(new StatModel(14, 0791, 23, 09, 10, 07, 22, 15));
            FixedStats.Add(new StatModel(15, 0832, 24, 09, 11, 07, 23, 15));
            FixedStats.Add(new StatModel(16, 0872, 25, 10, 11, 08, 23, 15));
            FixedStats.Add(new StatModel(17, 0913, 26, 10, 12, 08, 23, 15));
            FixedStats.Add(new StatModel(18, 0954, 26, 11, 12, 09, 23, 15));
            FixedStats.Add(new StatModel(19, 0994, 27, 11, 13, 09, 23, 15));
            FixedStats.Add(new StatModel(20, 1035, 28, 12, 14, 09, 23, 15));
            FixedStats.Add(new StatModel(21, 1075, 28, 12, 14, 10, 23, 15));
            FixedStats.Add(new StatModel(22, 1116, 29, 13, 15, 10, 23, 15));
            FixedStats.Add(new StatModel(23, 1156, 29, 13, 15, 11, 23, 15));
            FixedStats.Add(new StatModel(24, 1196, 30, 14, 16, 11, 23, 16));
            FixedStats.Add(new StatModel(25, 1236, 31, 14, 17, 12, 24, 16));
            FixedStats.Add(new StatModel(26, 1276, 31, 15, 17, 12, 24, 16));
            FixedStats.Add(new StatModel(27, 1316, 32, 15, 17, 12, 24, 16));
            FixedStats.Add(new StatModel(28, 1356, 32, 16, 18, 13, 24, 16));
            FixedStats.Add(new StatModel(29, 1396, 33, 16, 19, 13, 24, 16));
            FixedStats.Add(new StatModel(30, 1435, 34, 17, 19, 14, 25, 16));
            FixedStats.Add(new StatModel(31, 1475, 34, 17, 20, 14, 25, 16));
            FixedStats.Add(new StatModel(32, 1514, 35, 17, 20, 14, 25, 16));
            FixedStats.Add(new StatModel(33, 1554, 35, 18, 21, 15, 25, 16));
            FixedStats.Add(new StatModel(34, 1593, 36, 18, 21, 15, 25, 16));
            FixedStats.Add(new StatModel(35, 1632, 37, 19, 22, 15, 26, 16));
            FixedStats.Add(new StatModel(36, 1672, 37, 19, 22, 16, 26, 16));
            FixedStats.Add(new StatModel(37, 1711, 38, 20, 23, 16, 26, 16));
            FixedStats.Add(new StatModel(38, 1750, 38, 20, 23, 16, 26, 16));
            FixedStats.Add(new StatModel(39, 1789, 39, 20, 24, 17, 26, 16));
            FixedStats.Add(new StatModel(40, 1828, 39, 21, 24, 17, 26, 17));
            FixedStats.Add(new StatModel(41, 1867, 40, 21, 25, 17, 26, 17));
            FixedStats.Add(new StatModel(42, 1905, 40, 21, 25, 18, 26, 17));
            FixedStats.Add(new StatModel(43, 1944, 41, 22, 26, 18, 26, 17));
            FixedStats.Add(new StatModel(44, 1983, 41, 22, 26, 18, 26, 17));
            FixedStats.Add(new StatModel(45, 2021, 42, 23, 27, 18, 26, 17));
            FixedStats.Add(new StatModel(46, 2060, 42, 23, 27, 19, 27, 17));
            FixedStats.Add(new StatModel(47, 2098, 43, 23, 27, 19, 27, 17));
            FixedStats.Add(new StatModel(48, 2136, 43, 24, 28, 19, 27, 17));
            FixedStats.Add(new StatModel(49, 2174, 44, 24, 28, 20, 27, 17));
            FixedStats.Add(new StatModel(50, 2212, 44, 25, 29, 20, 28, 17));
            FixedStats.Add(new StatModel(51, 2250, 44, 25, 29, 20, 28, 17));
            FixedStats.Add(new StatModel(52, 2288, 45, 25, 30, 20, 28, 17));
            FixedStats.Add(new StatModel(53, 2326, 45, 25, 30, 21, 28, 17));
            FixedStats.Add(new StatModel(54, 2364, 46, 26, 30, 21, 28, 17));
            FixedStats.Add(new StatModel(55, 2402, 46, 26, 31, 21, 29, 17));
            FixedStats.Add(new StatModel(56, 2440, 47, 26, 31, 21, 29, 18));
            FixedStats.Add(new StatModel(57, 2477, 47, 27, 31, 22, 29, 18));
            FixedStats.Add(new StatModel(58, 2515, 47, 27, 32, 22, 29, 18));
            FixedStats.Add(new StatModel(59, 2552, 48, 27, 32, 22, 29, 18));
            FixedStats.Add(new StatModel(60, 2589, 48, 28, 33, 22, 29, 18));
            FixedStats.Add(new StatModel(61, 2627, 49, 28, 33, 23, 29, 18));
            FixedStats.Add(new StatModel(62, 2664, 49, 28, 33, 23, 29, 18));
            FixedStats.Add(new StatModel(63, 2701, 49, 28, 34, 23, 29, 18));
            FixedStats.Add(new StatModel(64, 2738, 50, 28, 34, 23, 29, 18));
            FixedStats.Add(new StatModel(65, 2775, 50, 29, 34, 23, 30, 18));
            FixedStats.Add(new StatModel(66, 2812, 51, 29, 35, 24, 30, 18));
            FixedStats.Add(new StatModel(67, 2848, 51, 29, 35, 24, 30, 18));
            FixedStats.Add(new StatModel(68, 2885, 51, 29, 35, 24, 30, 18));
            FixedStats.Add(new StatModel(69, 2922, 51, 29, 35, 24, 30, 18));
            FixedStats.Add(new StatModel(70, 2958, 52, 30, 36, 24, 31, 18));
            FixedStats.Add(new StatModel(71, 2995, 52, 30, 36, 24, 31, 18));
            FixedStats.Add(new StatModel(72, 3031, 52, 30, 36, 25, 31, 19));
            FixedStats.Add(new StatModel(73, 3068, 53, 30, 37, 25, 31, 19));
            FixedStats.Add(new StatModel(74, 3104, 53, 30, 37, 25, 31, 19));
            FixedStats.Add(new StatModel(75, 3140, 53, 31, 37, 25, 32, 19));
            FixedStats.Add(new StatModel(76, 3176, 54, 31, 37, 25, 32, 19));
            FixedStats.Add(new StatModel(77, 3212, 54, 31, 37, 25, 32, 19));
            FixedStats.Add(new StatModel(78, 3248, 54, 31, 38, 25, 32, 19));
            FixedStats.Add(new StatModel(79, 3284, 54, 31, 38, 26, 32, 19));
            FixedStats.Add(new StatModel(80, 3320, 55, 32, 38, 26, 32, 19));
            FixedStats.Add(new StatModel(81, 3355, 55, 32, 38, 26, 32, 19));
            FixedStats.Add(new StatModel(82, 3391, 55, 32, 39, 26, 32, 19));
            FixedStats.Add(new StatModel(83, 3426, 55, 32, 39, 26, 32, 19));
            FixedStats.Add(new StatModel(84, 3462, 56, 32, 39, 26, 32, 19));
            FixedStats.Add(new StatModel(85, 3497, 56, 32, 39, 26, 33, 19));
            FixedStats.Add(new StatModel(86, 3532, 56, 32, 40, 26, 33, 19));
            FixedStats.Add(new StatModel(87, 3568, 56, 32, 40, 26, 33, 19));
            FixedStats.Add(new StatModel(88, 3603, 57, 32, 40, 26, 33, 20));
            FixedStats.Add(new StatModel(89, 3638, 57, 32, 40, 26, 34, 20));
            FixedStats.Add(new StatModel(90, 3673, 57, 33, 40, 26, 34, 20));
            FixedStats.Add(new StatModel(91, 3708, 57, 33, 40, 26, 34, 20));
            FixedStats.Add(new StatModel(92, 3743, 57, 33, 41, 26, 34, 20));
            FixedStats.Add(new StatModel(93, 3777, 58, 33, 41, 26, 34, 20));
            FixedStats.Add(new StatModel(94, 3812, 58, 33, 41, 26, 35, 20));
            FixedStats.Add(new StatModel(95, 3847, 58, 33, 41, 26, 35, 20));
            FixedStats.Add(new StatModel(96, 3881, 58, 33, 41, 27, 35, 20));
            FixedStats.Add(new StatModel(97, 3916, 58, 33, 41, 27, 35, 20));
            FixedStats.Add(new StatModel(98, 3950, 58, 33, 41, 27, 35, 20));
            FixedStats.Add(new StatModel(99, 3984, 59, 33, 41, 27, 35, 20));
            FixedStats.Add(new StatModel(100, 4018, 59, 33, 42, 27, 35, 20));
        }

        #endregion

        public override string EvasionFormula => string.Empty;

        public override string ExperienceFormula => string.Empty;

        public override string HPFormula => string.Empty;

        public override string MagicFormula => string.Empty;

        public override string SpeedFormula => string.Empty;

        public override string SpiritFormula => string.Empty;

        public override string StrengthFormula => string.Empty;

        public override string VitalityFormula => string.Empty;

        public override bool IsPlayer => true;
    }
}
