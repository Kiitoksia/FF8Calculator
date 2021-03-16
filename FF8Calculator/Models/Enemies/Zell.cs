using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Zell : EnemyModel
    {
        public Zell() : base(181, "Zell", new Element[] { }, new Element[] { })
        {
            PopulateStats();
        }


        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 252, 2, 1, 1, 0, 20, 14));
            FixedStats.Add(new StatModel(2, 294, 3, 2, 2, 1, 20, 14));
            FixedStats.Add(new StatModel(3, 336, 3, 2, 2, 1, 20, 14));
            FixedStats.Add(new StatModel(4, 378, 4, 3, 3, 2, 20, 14));
            FixedStats.Add(new StatModel(5, 420, 5, 4, 4, 2, 21, 14));
            FixedStats.Add(new StatModel(6, 461, 6, 4, 5, 3, 21, 14));
            FixedStats.Add(new StatModel(7, 503, 7, 5, 5, 3, 21, 14));
            FixedStats.Add(new StatModel(8, 544, 7, 5, 6, 4, 21, 15));
            FixedStats.Add(new StatModel(9, 585, 8, 6, 6, 4, 21, 15));
            FixedStats.Add(new StatModel(10, 627, 9, 7, 7, 5, 22, 15));
            FixedStats.Add(new StatModel(11, 668, 9, 7, 8, 5, 22, 15));
            FixedStats.Add(new StatModel(12, 709, 10, 8, 9, 6, 22, 15));
            FixedStats.Add(new StatModel(13, 750, 11, 8, 9, 6, 22, 15));
            FixedStats.Add(new StatModel(14, 791, 11, 9, 10, 7, 22, 15));
            FixedStats.Add(new StatModel(15, 832, 12, 9, 11, 7, 23, 15));
            FixedStats.Add(new StatModel(16, 872, 13, 10, 11, 8, 23, 15));
            FixedStats.Add(new StatModel(17, 913, 14, 10, 12, 8, 23, 15));
            FixedStats.Add(new StatModel(18, 954, 14, 11, 12, 9, 23, 15));
            FixedStats.Add(new StatModel(19, 994, 15, 11, 13, 9, 23, 15));
            FixedStats.Add(new StatModel(20, 1035, 16, 12, 14, 9, 23, 15));
            FixedStats.Add(new StatModel(21, 1075, 16, 12, 14, 10, 23, 15));
            FixedStats.Add(new StatModel(22, 1116, 17, 13, 15, 10, 23, 15));
            FixedStats.Add(new StatModel(23, 1156, 17, 13, 15, 11, 23, 15));
            FixedStats.Add(new StatModel(24, 1196, 18, 14, 16, 11, 23, 16));
            FixedStats.Add(new StatModel(25, 1236, 19, 14, 17, 12, 24, 16));
            FixedStats.Add(new StatModel(26, 1276, 19, 15, 17, 12, 24, 16));
            FixedStats.Add(new StatModel(27, 1316, 20, 15, 17, 12, 24, 16));
            FixedStats.Add(new StatModel(28, 1356, 20, 16, 18, 13, 24, 16));
            FixedStats.Add(new StatModel(29, 1396, 21, 16, 19, 13, 24, 16));
            FixedStats.Add(new StatModel(30, 1435, 22, 17, 19, 14, 25, 16));
            FixedStats.Add(new StatModel(31, 1475, 22, 17, 20, 14, 25, 16));
            FixedStats.Add(new StatModel(32, 1514, 23, 17, 20, 14, 25, 16));
            FixedStats.Add(new StatModel(33, 1554, 23, 18, 21, 15, 25, 16));
            FixedStats.Add(new StatModel(34, 1593, 24, 18, 21, 15, 25, 16));
            FixedStats.Add(new StatModel(35, 1632, 25, 19, 22, 15, 26, 16));
            FixedStats.Add(new StatModel(36, 1672, 25, 19, 22, 16, 26, 16));
            FixedStats.Add(new StatModel(37, 1711, 26, 20, 23, 16, 26, 16));
            FixedStats.Add(new StatModel(38, 1750, 26, 20, 23, 16, 26, 16));
            FixedStats.Add(new StatModel(39, 1789, 27, 20, 24, 17, 26, 16));
            FixedStats.Add(new StatModel(40, 1828, 27, 21, 24, 17, 26, 17));
            FixedStats.Add(new StatModel(41, 1867, 28, 21, 25, 17, 26, 17));
            FixedStats.Add(new StatModel(42, 1905, 28, 21, 25, 18, 26, 17));
            FixedStats.Add(new StatModel(43, 1944, 29, 22, 26, 18, 26, 17));
            FixedStats.Add(new StatModel(44, 1983, 29, 22, 26, 18, 26, 17));
            FixedStats.Add(new StatModel(45, 2021, 30, 23, 27, 18, 27, 17));
            FixedStats.Add(new StatModel(46, 2060, 30, 23, 27, 19, 27, 17));
            FixedStats.Add(new StatModel(47, 2098, 31, 23, 27, 19, 27, 17));
            FixedStats.Add(new StatModel(48, 2136, 31, 24, 28, 19, 27, 17));
            FixedStats.Add(new StatModel(49, 2174, 32, 24, 28, 20, 27, 17));
            FixedStats.Add(new StatModel(50, 2212, 32, 25, 29, 20, 28, 17));
            FixedStats.Add(new StatModel(51, 2250, 32, 25, 29, 20, 28, 17));
            FixedStats.Add(new StatModel(52, 2288, 33, 25, 30, 20, 28, 17));
            FixedStats.Add(new StatModel(53, 2326, 33, 25, 30, 21, 28, 17));
            FixedStats.Add(new StatModel(54, 2364, 34, 26, 30, 21, 28, 17));
            FixedStats.Add(new StatModel(55, 2402, 34, 26, 31, 21, 29, 17));
            FixedStats.Add(new StatModel(56, 2440, 35, 26, 31, 21, 29, 18));
            FixedStats.Add(new StatModel(57, 2477, 35, 27, 31, 22, 29, 18));
            FixedStats.Add(new StatModel(58, 2515, 35, 27, 32, 22, 29, 18));
            FixedStats.Add(new StatModel(59, 2552, 36, 27, 32, 22, 29, 18));
            FixedStats.Add(new StatModel(60, 2589, 36, 28, 33, 22, 29, 18));
            FixedStats.Add(new StatModel(61, 2627, 37, 28, 33, 23, 29, 18));
            FixedStats.Add(new StatModel(62, 2664, 37, 28, 33, 23, 29, 18));
            FixedStats.Add(new StatModel(63, 2701, 37, 28, 34, 23, 29, 18));
            FixedStats.Add(new StatModel(64, 2738, 38, 28, 34, 23, 29, 18));
            FixedStats.Add(new StatModel(65, 2775, 38, 29, 34, 23, 30, 18));
            FixedStats.Add(new StatModel(66, 2812, 39, 29, 35, 24, 30, 18));
            FixedStats.Add(new StatModel(67, 2848, 39, 29, 35, 24, 30, 18));
            FixedStats.Add(new StatModel(68, 2885, 39, 29, 35, 24, 30, 18));
            FixedStats.Add(new StatModel(69, 2922, 39, 29, 35, 24, 30, 18));
            FixedStats.Add(new StatModel(70, 2958, 40, 30, 36, 24, 31, 18));
            FixedStats.Add(new StatModel(71, 2995, 40, 30, 36, 24, 31, 18));
            FixedStats.Add(new StatModel(72, 3031, 40, 30, 36, 25, 31, 19));
            FixedStats.Add(new StatModel(73, 3068, 41, 30, 37, 25, 31, 19));
            FixedStats.Add(new StatModel(74, 3104, 41, 30, 37, 25, 31, 19));
            FixedStats.Add(new StatModel(75, 3140, 41, 31, 37, 25, 32, 19));
            FixedStats.Add(new StatModel(76, 3176, 42, 31, 37, 25, 32, 19));
            FixedStats.Add(new StatModel(77, 3212, 42, 31, 37, 25, 32, 19));
            FixedStats.Add(new StatModel(78, 3248, 42, 31, 38, 25, 32, 19));
            FixedStats.Add(new StatModel(79, 3284, 42, 31, 38, 26, 32, 19));
            FixedStats.Add(new StatModel(80, 3320, 43, 32, 38, 26, 32, 19));
            FixedStats.Add(new StatModel(81, 3355, 43, 32, 38, 26, 32, 19));
            FixedStats.Add(new StatModel(82, 3391, 43, 32, 39, 26, 32, 19));
            FixedStats.Add(new StatModel(83, 3426, 43, 32, 39, 26, 32, 19));
            FixedStats.Add(new StatModel(84, 3462, 44, 32, 39, 26, 32, 19));
            FixedStats.Add(new StatModel(85, 3497, 44, 32, 39, 26, 33, 19));
            FixedStats.Add(new StatModel(86, 3532, 44, 32, 40, 26, 33, 19));
            FixedStats.Add(new StatModel(87, 3568, 44, 32, 40, 26, 33, 19));
            FixedStats.Add(new StatModel(88, 3603, 45, 32, 40, 26, 33, 20));
            FixedStats.Add(new StatModel(89, 3638, 45, 32, 40, 26, 33, 20));
            FixedStats.Add(new StatModel(90, 3673, 45, 33, 40, 26, 34, 20));
            FixedStats.Add(new StatModel(91, 3708, 45, 33, 40, 26, 34, 20));
            FixedStats.Add(new StatModel(92, 3743, 45, 33, 41, 26, 34, 20));
            FixedStats.Add(new StatModel(93, 3777, 46, 33, 41, 26, 34, 20));
            FixedStats.Add(new StatModel(94, 3812, 46, 33, 41, 26, 34, 20));
            FixedStats.Add(new StatModel(95, 3847, 46, 33, 41, 26, 35, 20));
            FixedStats.Add(new StatModel(96, 3881, 46, 33, 41, 27, 35, 20));
            FixedStats.Add(new StatModel(97, 3916, 46, 33, 41, 27, 35, 20));
            FixedStats.Add(new StatModel(98, 3950, 46, 33, 41, 27, 35, 20));
            FixedStats.Add(new StatModel(99, 3984, 47, 33, 41, 27, 35, 20));
            FixedStats.Add(new StatModel(100, 4018, 47, 33, 42, 27, 35, 20));
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
    }
}
