using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Quistis : EnemyModel
    {
        public Quistis() : base(183, "Quistis", new Element[] { }, new Element[] { })
        {
            PopulateStats();
        }


        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 216, 1, 1, 1, 2, 19, 14));
            FixedStats.Add(new StatModel(2, 257, 2, 2, 2, 3, 19, 14));
            FixedStats.Add(new StatModel(3, 298, 3, 2, 3, 3, 19, 14));
            FixedStats.Add(new StatModel(4, 339, 4, 3, 4, 4, 19, 14));
            FixedStats.Add(new StatModel(5, 380, 4, 3, 4, 5, 20, 14));
            FixedStats.Add(new StatModel(6, 420, 5, 4, 5, 5, 20, 14));
            FixedStats.Add(new StatModel(7, 461, 6, 4, 6, 6, 20, 15));
            FixedStats.Add(new StatModel(8, 501, 7, 5, 6, 6, 20, 15));
            FixedStats.Add(new StatModel(9, 541, 7, 6, 7, 7, 20, 15));
            FixedStats.Add(new StatModel(10, 582, 8, 6, 8, 8, 21, 15));
            FixedStats.Add(new StatModel(11, 622, 9, 7, 8, 8, 21, 15));
            FixedStats.Add(new StatModel(12, 662, 10, 7, 9, 9, 21, 15));
            FixedStats.Add(new StatModel(13, 702, 10, 8, 9, 9, 21, 15));
            FixedStats.Add(new StatModel(14, 742, 11, 8, 10, 10, 21, 15));
            FixedStats.Add(new StatModel(15, 782, 12, 9, 11, 10, 22, 15));
            FixedStats.Add(new StatModel(16, 821, 12, 9, 11, 11, 22, 15));
            FixedStats.Add(new StatModel(17, 861, 13, 10, 12, 11, 22, 15));
            FixedStats.Add(new StatModel(18, 901, 14, 10, 13, 12, 22, 15));
            FixedStats.Add(new StatModel(19, 940, 14, 10, 13, 12, 22, 15));
            FixedStats.Add(new StatModel(20, 980, 15, 11, 14, 13, 22, 15));
            FixedStats.Add(new StatModel(21, 1019, 15, 12, 14, 13, 22, 16));
            FixedStats.Add(new StatModel(22, 1059, 16, 12, 15, 14, 22, 16));
            FixedStats.Add(new StatModel(23, 1098, 17, 12, 15, 14, 22, 16));
            FixedStats.Add(new StatModel(24, 1137, 17, 13, 16, 15, 22, 16));
            FixedStats.Add(new StatModel(25, 1176, 18, 13, 17, 15, 23, 16));
            FixedStats.Add(new StatModel(26, 1215, 19, 14, 17, 16, 23, 16));
            FixedStats.Add(new StatModel(27, 1254, 19, 14, 18, 16, 23, 16));
            FixedStats.Add(new StatModel(28, 1293, 20, 15, 18, 17, 23, 16));
            FixedStats.Add(new StatModel(29, 1332, 20, 15, 19, 17, 23, 16));
            FixedStats.Add(new StatModel(30, 1370, 21, 16, 20, 18, 24, 16));
            FixedStats.Add(new StatModel(31, 1409, 21, 16, 20, 18, 24, 16));
            FixedStats.Add(new StatModel(32, 1447, 22, 17, 21, 18, 24, 16));
            FixedStats.Add(new StatModel(33, 1486, 23, 17, 21, 19, 24, 16));
            FixedStats.Add(new StatModel(34, 1524, 23, 17, 22, 19, 24, 16));
            FixedStats.Add(new StatModel(35, 1562, 24, 17, 22, 20, 25, 17));
            FixedStats.Add(new StatModel(36, 1601, 24, 18, 23, 20, 25, 17));
            FixedStats.Add(new StatModel(37, 1639, 25, 18, 23, 20, 25, 17));
            FixedStats.Add(new StatModel(38, 1677, 25, 19, 23, 21, 25, 17));
            FixedStats.Add(new StatModel(39, 1715, 26, 19, 24, 21, 25, 17));
            FixedStats.Add(new StatModel(40, 1753, 26, 20, 25, 22, 25, 17));
            FixedStats.Add(new StatModel(41, 1791, 27, 20, 25, 22, 25, 17));
            FixedStats.Add(new StatModel(42, 1828, 27, 20, 25, 22, 25, 17));
            FixedStats.Add(new StatModel(43, 1866, 28, 20, 26, 23, 25, 17));
            FixedStats.Add(new StatModel(44, 1904, 28, 21, 26, 23, 25, 17));
            FixedStats.Add(new StatModel(45, 1941, 29, 21, 27, 24, 26, 17));
            FixedStats.Add(new StatModel(46, 1979, 29, 21, 27, 24, 26, 17));
            FixedStats.Add(new StatModel(47, 2016, 30, 22, 28, 24, 26, 17));
            FixedStats.Add(new StatModel(48, 2053, 31, 22, 28, 25, 26, 17));
            FixedStats.Add(new StatModel(49, 2090, 31, 22, 29, 25, 26, 18));
            FixedStats.Add(new StatModel(50, 2127, 31, 23, 29, 26, 27, 18));
            FixedStats.Add(new StatModel(51, 2164, 32, 23, 29, 26, 27, 18));
            FixedStats.Add(new StatModel(52, 2201, 32, 23, 30, 26, 27, 18));
            FixedStats.Add(new StatModel(53, 2238, 32, 24, 30, 26, 27, 18));
            FixedStats.Add(new StatModel(54, 2275, 33, 24, 31, 27, 27, 18));
            FixedStats.Add(new StatModel(55, 2312, 34, 24, 31, 27, 28, 18));
            FixedStats.Add(new StatModel(56, 2349, 34, 24, 31, 27, 28, 18));
            FixedStats.Add(new StatModel(57, 2385, 34, 25, 32, 27, 28, 18));
            FixedStats.Add(new StatModel(58, 2422, 35, 25, 32, 28, 28, 18));
            FixedStats.Add(new StatModel(59, 2458, 35, 25, 32, 28, 28, 18));
            FixedStats.Add(new StatModel(60, 2494, 36, 26, 33, 29, 28, 18));
            FixedStats.Add(new StatModel(61, 2531, 36, 26, 33, 29, 28, 18));
            FixedStats.Add(new StatModel(62, 2567, 36, 26, 34, 29, 28, 18));
            FixedStats.Add(new StatModel(63, 2603, 37, 26, 34, 29, 28, 19));
            FixedStats.Add(new StatModel(64, 2639, 37, 26, 34, 29, 28, 19));
            FixedStats.Add(new StatModel(65, 2675, 37, 26, 35, 30, 29, 19));
            FixedStats.Add(new StatModel(66, 2711, 38, 27, 35, 30, 29, 19));
            FixedStats.Add(new StatModel(67, 2746, 38, 27, 35, 30, 29, 19));
            FixedStats.Add(new StatModel(68, 2782, 39, 27, 35, 30, 29, 19));
            FixedStats.Add(new StatModel(69, 2818, 39, 27, 36, 30, 29, 19));
            FixedStats.Add(new StatModel(70, 2853, 39, 28, 36, 31, 30, 19));
            FixedStats.Add(new StatModel(71, 2889, 39, 28, 36, 31, 30, 19));
            FixedStats.Add(new StatModel(72, 2924, 40, 28, 37, 31, 30, 19));
            FixedStats.Add(new StatModel(73, 2960, 40, 28, 37, 31, 30, 19));
            FixedStats.Add(new StatModel(74, 2995, 40, 28, 37, 31, 30, 19));
            FixedStats.Add(new StatModel(75, 3030, 41, 28, 38, 32, 31, 19));
            FixedStats.Add(new StatModel(76, 3065, 41, 28, 38, 32, 31, 19));
            FixedStats.Add(new StatModel(77, 3100, 41, 29, 38, 32, 31, 20));
            FixedStats.Add(new StatModel(78, 3135, 42, 29, 38, 32, 31, 20));
            FixedStats.Add(new StatModel(79, 3170, 42, 29, 38, 32, 31, 20));
            FixedStats.Add(new StatModel(80, 3205, 42, 29, 39, 33, 31, 20));
            FixedStats.Add(new StatModel(81, 3239, 42, 29, 39, 33, 31, 20));
            FixedStats.Add(new StatModel(82, 3274, 42, 29, 39, 33, 31, 20));
            FixedStats.Add(new StatModel(83, 3308, 43, 29, 39, 33, 31, 20));
            FixedStats.Add(new StatModel(84, 3343, 43, 29, 40, 33, 31, 20));
            FixedStats.Add(new StatModel(85, 3377, 43, 29, 40, 33, 32, 20));
            FixedStats.Add(new StatModel(86, 3411, 44, 29, 40, 33, 32, 20));
            FixedStats.Add(new StatModel(87, 3446, 44, 29, 40, 33, 32, 20));
            FixedStats.Add(new StatModel(88, 3480, 44, 30, 40, 33, 32, 20));
            FixedStats.Add(new StatModel(89, 3514, 44, 30, 41, 33, 32, 20));
            FixedStats.Add(new StatModel(90, 3548, 45, 30, 41, 34, 33, 20));
            FixedStats.Add(new StatModel(91, 3582, 45, 30, 41, 34, 33, 21));
            FixedStats.Add(new StatModel(92, 3616, 45, 30, 41, 34, 33, 21));
            FixedStats.Add(new StatModel(93, 3649, 45, 30, 41, 34, 33, 21));
            FixedStats.Add(new StatModel(94, 3683, 45, 30, 41, 34, 33, 21));
            FixedStats.Add(new StatModel(95, 3717, 45, 30, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(96, 3750, 46, 30, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(97, 3784, 46, 30, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(98, 3817, 46, 30, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(99, 3850, 46, 30, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(100, 3883, 46, 30, 42, 34, 34, 21));
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
