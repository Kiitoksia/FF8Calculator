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
            PopulateStats();
        }

        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(13, 0699, 22, 08, 10, 07, 22, 14));
            FixedStats.Add(new StatModel(14, 0739, 22, 08, 10, 08, 22, 14));
            FixedStats.Add(new StatModel(15, 0779, 23, 09, 11, 08, 22, 14));
            FixedStats.Add(new StatModel(16, 0818, 23, 10, 12, 09, 23, 15));
            FixedStats.Add(new StatModel(17, 0858, 24, 10, 12, 09, 23, 15));
            FixedStats.Add(new StatModel(18, 0898, 25, 11, 13, 10, 23, 15));
            FixedStats.Add(new StatModel(19, 0937, 25, 11, 14, 10, 23, 15));
            FixedStats.Add(new StatModel(20, 0977, 26, 12, 14, 11, 23, 15));
            FixedStats.Add(new StatModel(21, 1016, 26, 12, 15, 11, 23, 15));
            FixedStats.Add(new StatModel(22, 1056, 27, 12, 15, 12, 23, 15));
            FixedStats.Add(new StatModel(23, 1095, 28, 13, 16, 12, 23, 15));
            FixedStats.Add(new StatModel(24, 1134, 28, 13, 17, 13, 24, 15));
            FixedStats.Add(new StatModel(25, 1173, 29, 14, 17, 13, 24, 15));
            FixedStats.Add(new StatModel(26, 1212, 29, 14, 18, 14, 24, 15));
            FixedStats.Add(new StatModel(27, 1251, 30, 15, 18, 14, 24, 15));
            FixedStats.Add(new StatModel(28, 1290, 31, 15, 19, 14, 25, 15));
            FixedStats.Add(new StatModel(29, 1329, 31, 15, 19, 15, 25, 15));
            FixedStats.Add(new StatModel(30, 1367, 32, 16, 20, 15, 25, 15));
            FixedStats.Add(new StatModel(31, 1406, 32, 16, 20, 16, 25, 15));
            FixedStats.Add(new StatModel(32, 1444, 33, 17, 21, 16, 26, 16));
            FixedStats.Add(new StatModel(33, 1483, 33, 17, 22, 16, 26, 16));
            FixedStats.Add(new StatModel(34, 1521, 34, 17, 22, 17, 26, 16));
            FixedStats.Add(new StatModel(35, 1559, 34, 18, 22, 17, 26, 16));
            FixedStats.Add(new StatModel(36, 1598, 35, 18, 23, 18, 27, 16));
            FixedStats.Add(new StatModel(37, 1636, 35, 19, 23, 18, 27, 16));
            FixedStats.Add(new StatModel(38, 1674, 36, 19, 24, 18, 27, 16));
            FixedStats.Add(new StatModel(39, 1712, 36, 19, 24, 18, 27, 16));
            FixedStats.Add(new StatModel(40, 1750, 37, 20, 25, 19, 27, 17));
            FixedStats.Add(new StatModel(41, 1788, 37, 20, 25, 19, 27, 17));
            FixedStats.Add(new StatModel(42, 1825, 38, 21, 26, 20, 27, 17));
            FixedStats.Add(new StatModel(43, 1863, 38, 21, 26, 20, 27, 17));
            FixedStats.Add(new StatModel(44, 1901, 39, 21, 27, 20, 28, 17));
            FixedStats.Add(new StatModel(45, 1938, 39, 22, 27, 21, 28, 17));
            FixedStats.Add(new StatModel(46, 1976, 40, 22, 28, 21, 28, 17));
            FixedStats.Add(new StatModel(47, 2013, 40, 22, 28, 21, 28, 17));
            FixedStats.Add(new StatModel(48, 2050, 41, 23, 29, 22, 29, 17));
            FixedStats.Add(new StatModel(49, 2087, 41, 23, 29, 22, 29, 17));
            FixedStats.Add(new StatModel(50, 2124, 42, 23, 30, 22, 29, 17));
            FixedStats.Add(new StatModel(51, 2161, 42, 23, 30, 22, 29, 17));
            FixedStats.Add(new StatModel(52, 2198, 42, 24, 30, 23, 30, 17));
            FixedStats.Add(new StatModel(53, 2235, 43, 24, 31, 23, 30, 17));
            FixedStats.Add(new StatModel(54, 2272, 43, 24, 31, 23, 30, 17));
            FixedStats.Add(new StatModel(55, 2309, 44, 25, 31, 24, 30, 17));
            FixedStats.Add(new StatModel(56, 2346, 44, 25, 32, 24, 31, 18));
            FixedStats.Add(new StatModel(57, 2382, 44, 25, 32, 24, 31, 18));
            FixedStats.Add(new StatModel(58, 2419, 45, 25, 32, 24, 31, 18));
            FixedStats.Add(new StatModel(59, 2455, 45, 25, 33, 24, 31, 18));
            FixedStats.Add(new StatModel(60, 2491, 46, 26, 33, 25, 31, 18));
            FixedStats.Add(new StatModel(61, 2528, 46, 26, 34, 25, 31, 18));
            FixedStats.Add(new StatModel(62, 2564, 46, 26, 34, 25, 31, 18));
            FixedStats.Add(new StatModel(63, 2600, 47, 26, 34, 25, 31, 18));
            FixedStats.Add(new StatModel(64, 2636, 47, 27, 35, 26, 32, 19));
            FixedStats.Add(new StatModel(65, 2672, 48, 27, 35, 26, 32, 19));
            FixedStats.Add(new StatModel(66, 2708, 48, 27, 35, 26, 32, 19));
            FixedStats.Add(new StatModel(67, 2743, 48, 27, 35, 26, 32, 19));
            FixedStats.Add(new StatModel(68, 2779, 49, 28, 36, 26, 33, 19));
            FixedStats.Add(new StatModel(69, 2815, 49, 28, 36, 26, 33, 19));
            FixedStats.Add(new StatModel(70, 2850, 49, 28, 36, 27, 33, 19));
            FixedStats.Add(new StatModel(71, 2886, 50, 28, 36, 27, 33, 19));
            FixedStats.Add(new StatModel(72, 2921, 50, 28, 37, 27, 34, 19));
            FixedStats.Add(new StatModel(73, 2957, 50, 29, 37, 27, 34, 19));
            FixedStats.Add(new StatModel(74, 2992, 51, 29, 37, 27, 34, 19));
            FixedStats.Add(new StatModel(75, 3027, 51, 29, 37, 27, 34, 19));
            FixedStats.Add(new StatModel(76, 3062, 51, 29, 38, 27, 35, 19));
            FixedStats.Add(new StatModel(77, 3097, 51, 29, 38, 27, 35, 19));
            FixedStats.Add(new StatModel(78, 3132, 52, 29, 38, 27, 35, 19));
            FixedStats.Add(new StatModel(79, 3167, 52, 29, 38, 27, 35, 19));
            FixedStats.Add(new StatModel(80, 3202, 52, 30, 39, 28, 35, 20));
            FixedStats.Add(new StatModel(81, 3236, 52, 30, 39, 28, 35, 20));
            FixedStats.Add(new StatModel(82, 3271, 53, 30, 39, 28, 35, 20));
            FixedStats.Add(new StatModel(83, 3305, 53, 30, 39, 28, 35, 20));
            FixedStats.Add(new StatModel(84, 3340, 53, 30, 40, 28, 36, 20));
            FixedStats.Add(new StatModel(85, 3374, 54, 30, 40, 28, 36, 20));
            FixedStats.Add(new StatModel(86, 3480, 54, 30, 40, 28, 36, 20));
            FixedStats.Add(new StatModel(87, 3443, 54, 30, 40, 28, 36, 20));
            FixedStats.Add(new StatModel(88, 3477, 54, 30, 40, 28, 37, 21));
            FixedStats.Add(new StatModel(89, 3511, 55, 30, 40, 28, 37, 21));
            FixedStats.Add(new StatModel(90, 3545, 55, 31, 41, 28, 37, 21));
            FixedStats.Add(new StatModel(91, 3579, 55, 31, 41, 28, 37, 21));
            FixedStats.Add(new StatModel(92, 3613, 55, 31, 41, 28, 38, 21));
            FixedStats.Add(new StatModel(93, 3546, 55, 31, 41, 28, 38, 21));
            FixedStats.Add(new StatModel(94, 3680, 56, 31, 41, 28, 38, 21));
            FixedStats.Add(new StatModel(95, 3714, 56, 31, 41, 28, 38, 21));
            FixedStats.Add(new StatModel(96, 3747, 56, 31, 41, 28, 39, 21));
            FixedStats.Add(new StatModel(97, 3781, 56, 31, 41, 28, 39, 21));
            FixedStats.Add(new StatModel(98, 3814, 56, 31, 41, 28, 39, 21));
            FixedStats.Add(new StatModel(99, 3847, 57, 31, 42, 28, 39, 21));
            FixedStats.Add(new StatModel(100, 3880, 57, 31, 42, 28, 39, 21));
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
