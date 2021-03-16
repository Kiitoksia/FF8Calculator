using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Irvine : EnemyModel
    {
        public Irvine() : base(184, "Irvine", new Element[] { }, new Element[] { })
        {

        }

        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 213, 1, 1, 1, 0, 19, 13));
            FixedStats.Add(new StatModel(2, 254, 2, 2, 2, 1, 19, 13));
            FixedStats.Add(new StatModel(3, 295, 3, 2, 3, 1, 19, 13));
            FixedStats.Add(new StatModel(4, 336, 4, 3, 4, 2, 20, 13));
            FixedStats.Add(new StatModel(5, 377, 4, 4, 4, 3, 20, 13));
            FixedStats.Add(new StatModel(6, 417, 5, 4, 5, 3, 20, 13));
            FixedStats.Add(new StatModel(7, 458, 6, 5, 6, 4, 20, 13));
            FixedStats.Add(new StatModel(8, 498, 6, 5, 7, 5, 21, 14));
            FixedStats.Add(new StatModel(9, 538, 7, 6, 7, 5, 21, 14));
            FixedStats.Add(new StatModel(10, 579, 8, 6, 8, 6, 21, 14));
            FixedStats.Add(new StatModel(11, 619, 8, 7, 8, 6, 21, 14));
            FixedStats.Add(new StatModel(12, 659, 9, 8, 9, 7, 22, 14));
            FixedStats.Add(new StatModel(13, 699, 10, 8, 10, 7, 22, 14));
            FixedStats.Add(new StatModel(14, 739, 10, 8, 10, 8, 22, 14));
            FixedStats.Add(new StatModel(15, 779, 11, 9, 11, 8, 22, 14));
            FixedStats.Add(new StatModel(16, 818, 11, 10, 12, 9, 23, 15));
            FixedStats.Add(new StatModel(17, 858, 12, 10, 12, 9, 23, 15));
            FixedStats.Add(new StatModel(18, 898, 13, 11, 13, 10, 23, 15));
            FixedStats.Add(new StatModel(19, 937, 13, 11, 14, 10, 23, 15));
            FixedStats.Add(new StatModel(20, 977, 14, 12, 14, 11, 23, 15));
            FixedStats.Add(new StatModel(21, 1016, 14, 12, 15, 11, 23, 15));
            FixedStats.Add(new StatModel(22, 1056, 15, 12, 15, 12, 23, 15));
            FixedStats.Add(new StatModel(23, 1095, 16, 13, 16, 12, 23, 15));
            FixedStats.Add(new StatModel(24, 1134, 16, 13, 17, 13, 24, 15));
            FixedStats.Add(new StatModel(25, 1173, 17, 14, 17, 13, 24, 15));
            FixedStats.Add(new StatModel(26, 1212, 17, 14, 18, 14, 24, 15));
            FixedStats.Add(new StatModel(27, 1251, 18, 15, 18, 14, 24, 15));
            FixedStats.Add(new StatModel(28, 1290, 19, 15, 19, 14, 25, 15));
            FixedStats.Add(new StatModel(29, 1329, 19, 15, 19, 15, 25, 15));
            FixedStats.Add(new StatModel(30, 1367, 20, 16, 20, 15, 25, 15));
            FixedStats.Add(new StatModel(31, 1406, 20, 16, 20, 16, 25, 15));
            FixedStats.Add(new StatModel(32, 1444, 21, 17, 21, 16, 26, 16));
            FixedStats.Add(new StatModel(33, 1483, 21, 17, 22, 16, 26, 16));
            FixedStats.Add(new StatModel(34, 1521, 22, 17, 22, 17, 26, 16));
            FixedStats.Add(new StatModel(35, 1559, 22, 18, 22, 17, 26, 16));
            FixedStats.Add(new StatModel(36, 1598, 23, 18, 23, 18, 27, 16));
            FixedStats.Add(new StatModel(37, 1636, 23, 19, 23, 18, 27, 16));
            FixedStats.Add(new StatModel(38, 1674, 24, 19, 24, 18, 27, 16));
            FixedStats.Add(new StatModel(39, 1712, 24, 19, 24, 18, 27, 16));
            FixedStats.Add(new StatModel(40, 1750, 25, 20, 25, 19, 27, 17));
            FixedStats.Add(new StatModel(41, 1788, 25, 20, 25, 19, 27, 17));
            FixedStats.Add(new StatModel(42, 1825, 26, 21, 26, 20, 27, 17));
            FixedStats.Add(new StatModel(43, 1863, 26, 21, 26, 20, 27, 17));
            FixedStats.Add(new StatModel(44, 1901, 27, 21, 27, 20, 28, 17));
            FixedStats.Add(new StatModel(45, 1938, 27, 22, 27, 21, 28, 17));
            FixedStats.Add(new StatModel(46, 1976, 28, 22, 28, 21, 28, 17));
            FixedStats.Add(new StatModel(47, 2013, 28, 22, 28, 21, 28, 17));
            FixedStats.Add(new StatModel(48, 2050, 29, 23, 29, 22, 29, 17));
            FixedStats.Add(new StatModel(49, 2087, 29, 23, 29, 22, 29, 17));
            FixedStats.Add(new StatModel(50, 2124, 30, 23, 30, 22, 29, 17));
            FixedStats.Add(new StatModel(51, 2161, 30, 23, 30, 22, 29, 17));
            FixedStats.Add(new StatModel(52, 2198, 30, 24, 30, 23, 30, 17));
            FixedStats.Add(new StatModel(53, 2235, 31, 24, 31, 23, 30, 17));
            FixedStats.Add(new StatModel(54, 2272, 31, 24, 31, 23, 30, 17));
            FixedStats.Add(new StatModel(55, 2309, 32, 25, 31, 24, 30, 17));
            FixedStats.Add(new StatModel(56, 2346, 32, 25, 32, 24, 31, 18));
            FixedStats.Add(new StatModel(57, 2382, 32, 25, 32, 24, 31, 18));
            FixedStats.Add(new StatModel(58, 2419, 33, 25, 32, 24, 31, 18));
            FixedStats.Add(new StatModel(59, 2455, 33, 25, 33, 24, 31, 18));
            FixedStats.Add(new StatModel(60, 2491, 34, 26, 33, 25, 31, 18));
            FixedStats.Add(new StatModel(61, 2528, 34, 26, 34, 25, 31, 18));
            FixedStats.Add(new StatModel(62, 2564, 34, 26, 34, 25, 31, 18));
            FixedStats.Add(new StatModel(63, 2600, 35, 26, 34, 25, 31, 18));
            FixedStats.Add(new StatModel(64, 2636, 35, 27, 35, 26, 32, 19));
            FixedStats.Add(new StatModel(65, 2672, 36, 27, 35, 26, 32, 19));
            FixedStats.Add(new StatModel(66, 2708, 36, 27, 35, 26, 32, 19));
            FixedStats.Add(new StatModel(67, 2743, 36, 27, 35, 26, 32, 19));
            FixedStats.Add(new StatModel(68, 2779, 37, 28, 36, 26, 33, 19));
            FixedStats.Add(new StatModel(69, 2815, 37, 28, 36, 26, 33, 19));
            FixedStats.Add(new StatModel(70, 2850, 37, 28, 36, 27, 33, 19));
            FixedStats.Add(new StatModel(71, 2886, 38, 28, 36, 27, 33, 19));
            FixedStats.Add(new StatModel(72, 2921, 38, 28, 37, 27, 34, 19));
            FixedStats.Add(new StatModel(73, 2957, 38, 29, 37, 27, 34, 19));
            FixedStats.Add(new StatModel(74, 2992, 39, 29, 37, 27, 34, 19));
            FixedStats.Add(new StatModel(75, 3027, 39, 29, 37, 27, 34, 19));
            FixedStats.Add(new StatModel(76, 3062, 39, 29, 38, 27, 35, 19));
            FixedStats.Add(new StatModel(77, 3097, 39, 29, 38, 27, 35, 19));
            FixedStats.Add(new StatModel(78, 3132, 40, 29, 38, 27, 35, 19));
            FixedStats.Add(new StatModel(79, 3167, 40, 29, 38, 27, 35, 19));
            FixedStats.Add(new StatModel(80, 3202, 40, 30, 39, 28, 35, 20));
            FixedStats.Add(new StatModel(81, 3236, 40, 30, 39, 28, 35, 20));
            FixedStats.Add(new StatModel(82, 3271, 41, 30, 39, 28, 35, 20));
            FixedStats.Add(new StatModel(83, 3305, 41, 30, 39, 28, 35, 20));
            FixedStats.Add(new StatModel(84, 3340, 41, 30, 40, 28, 36, 20));
            FixedStats.Add(new StatModel(85, 3374, 42, 30, 40, 28, 36, 20));
            FixedStats.Add(new StatModel(86, 3408, 42, 30, 40, 28, 36, 20));
            FixedStats.Add(new StatModel(87, 3443, 42, 30, 40, 28, 36, 20));
            FixedStats.Add(new StatModel(88, 3477, 42, 30, 40, 28, 37, 21));
            FixedStats.Add(new StatModel(89, 3511, 43, 30, 40, 28, 37, 21));
            FixedStats.Add(new StatModel(90, 3545, 43, 31, 41, 28, 37, 21));
            FixedStats.Add(new StatModel(91, 3579, 43, 31, 41, 28, 37, 21));
            FixedStats.Add(new StatModel(92, 3613, 43, 31, 41, 28, 38, 21));
            FixedStats.Add(new StatModel(93, 3646, 43, 31, 41, 28, 38, 21));
            FixedStats.Add(new StatModel(94, 3680, 44, 31, 41, 28, 38, 21));
            FixedStats.Add(new StatModel(95, 3714, 44, 31, 41, 28, 38, 21));
            FixedStats.Add(new StatModel(96, 3747, 44, 31, 41, 28, 39, 21));
            FixedStats.Add(new StatModel(97, 3781, 44, 31, 41, 28, 39, 21));
            FixedStats.Add(new StatModel(98, 3814, 44, 31, 41, 28, 39, 21));
            FixedStats.Add(new StatModel(99, 3847, 45, 31, 42, 28, 39, 21));
            FixedStats.Add(new StatModel(100, 3880, 45, 31, 42, 28, 39, 21));
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
