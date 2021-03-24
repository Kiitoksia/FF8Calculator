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
            FixedStats.Add(new StatModel(08, 0501, 19, 05, 06, 06, 20, 15));
            FixedStats.Add(new StatModel(09, 0541, 19, 06, 07, 07, 20, 15));
            FixedStats.Add(new StatModel(10, 0582, 20, 06, 08, 08, 21, 15));
            FixedStats.Add(new StatModel(11, 0622, 21, 07, 08, 08, 21, 15));
            FixedStats.Add(new StatModel(12, 0662, 22, 07, 09, 09, 21, 15));
            FixedStats.Add(new StatModel(13, 0702, 22, 08, 09, 09, 21, 15));
            FixedStats.Add(new StatModel(14, 0742, 23, 08, 10, 10, 21, 15));
            FixedStats.Add(new StatModel(15, 0782, 24, 09, 11, 10, 22, 15));
            FixedStats.Add(new StatModel(16, 0821, 24, 09, 11, 11, 22, 15));
            FixedStats.Add(new StatModel(17, 0861, 25, 10, 12, 11, 22, 15));
            FixedStats.Add(new StatModel(18, 0901, 26, 10, 13, 12, 22, 15));
            FixedStats.Add(new StatModel(19, 0940, 26, 10, 13, 12, 22, 15));
            FixedStats.Add(new StatModel(20, 0980, 27, 11, 14, 13, 22, 15));
            FixedStats.Add(new StatModel(21, 1000, 27, 12, 14, 13, 22, 16));
            FixedStats.Add(new StatModel(22, 1059, 28, 12, 15, 14, 22, 16));
            FixedStats.Add(new StatModel(23, 1098, 29, 12, 15, 14, 22, 16));
            FixedStats.Add(new StatModel(24, 1137, 29, 13, 16, 15, 22, 16));
            FixedStats.Add(new StatModel(25, 1176, 30, 13, 17, 15, 23, 16));
            FixedStats.Add(new StatModel(26, 1215, 31, 14, 17, 16, 23, 16));
            FixedStats.Add(new StatModel(27, 1254, 31, 14, 18, 16, 23, 16));
            FixedStats.Add(new StatModel(28, 1293, 32, 15, 18, 17, 23, 16));
            FixedStats.Add(new StatModel(29, 1332, 32, 15, 19, 17, 23, 16));
            FixedStats.Add(new StatModel(30, 1370, 33, 16, 20, 18, 24, 16));
            FixedStats.Add(new StatModel(31, 1409, 33, 16, 20, 18, 24, 16));
            FixedStats.Add(new StatModel(32, 1447, 34, 17, 21, 18, 24, 16));
            FixedStats.Add(new StatModel(33, 1486, 35, 17, 21, 19, 24, 16));
            FixedStats.Add(new StatModel(34, 1524, 35, 17, 22, 19, 24, 16));
            FixedStats.Add(new StatModel(35, 1562, 36, 17, 22, 20, 25, 17));
            FixedStats.Add(new StatModel(36, 1601, 36, 18, 23, 20, 25, 17));
            FixedStats.Add(new StatModel(37, 1639, 37, 18, 23, 20, 25, 17));
            FixedStats.Add(new StatModel(38, 1677, 37, 19, 23, 21, 25, 17));
            FixedStats.Add(new StatModel(39, 1715, 38, 19, 24, 21, 25, 17));
            FixedStats.Add(new StatModel(40, 1753, 38, 20, 25, 22, 25, 17));
            FixedStats.Add(new StatModel(41, 1791, 39, 20, 25, 22, 25, 17));
            FixedStats.Add(new StatModel(42, 1828, 39, 20, 25, 22, 25, 17));
            FixedStats.Add(new StatModel(43, 1866, 40, 20, 26, 23, 25, 17));
            FixedStats.Add(new StatModel(44, 1904, 40, 21, 26, 23, 25, 17));
            FixedStats.Add(new StatModel(45, 1941, 41, 21, 27, 24, 26, 17));
            FixedStats.Add(new StatModel(46, 1979, 41, 21, 27, 24, 26, 17));
            FixedStats.Add(new StatModel(47, 2016, 42, 22, 28, 24, 26, 17));
            FixedStats.Add(new StatModel(48, 2053, 43, 22, 28, 25, 26, 17));
            FixedStats.Add(new StatModel(49, 2090, 43, 22, 29, 25, 26, 18));
            FixedStats.Add(new StatModel(50, 2127, 43, 23, 29, 26, 27, 18));
            FixedStats.Add(new StatModel(51, 2164, 44, 23, 29, 26, 27, 18));
            FixedStats.Add(new StatModel(52, 2201, 44, 23, 30, 26, 27, 18));
            FixedStats.Add(new StatModel(53, 2238, 44, 24, 30, 26, 27, 18));
            FixedStats.Add(new StatModel(54, 2275, 45, 24, 31, 27, 27, 18));
            FixedStats.Add(new StatModel(55, 2312, 46, 24, 31, 27, 28, 18));
            FixedStats.Add(new StatModel(56, 2349, 46, 24, 31, 27, 28, 18));
            FixedStats.Add(new StatModel(57, 2385, 46, 25, 32, 27, 28, 18));
            FixedStats.Add(new StatModel(58, 2422, 47, 25, 32, 28, 28, 18));
            FixedStats.Add(new StatModel(59, 2458, 47, 25, 32, 28, 28, 18));
            FixedStats.Add(new StatModel(60, 2494, 48, 26, 33, 29, 28, 18));
            FixedStats.Add(new StatModel(61, 2531, 48, 26, 33, 29, 28, 18));
            FixedStats.Add(new StatModel(62, 2567, 48, 26, 34, 29, 28, 18));
            FixedStats.Add(new StatModel(63, 2603, 49, 26, 34, 29, 28, 19));
            FixedStats.Add(new StatModel(64, 2639, 49, 26, 34, 29, 28, 19));
            FixedStats.Add(new StatModel(65, 2675, 49, 26, 35, 30, 29, 19));
            FixedStats.Add(new StatModel(66, 2711, 50, 27, 35, 30, 29, 19));
            FixedStats.Add(new StatModel(67, 2746, 50, 27, 35, 30, 29, 19));
            FixedStats.Add(new StatModel(68, 2782, 51, 27, 35, 30, 29, 19));
            FixedStats.Add(new StatModel(69, 2818, 51, 27, 36, 30, 29, 19));
            FixedStats.Add(new StatModel(70, 2853, 51, 28, 36, 31, 30, 19));
            FixedStats.Add(new StatModel(71, 2889, 51, 28, 36, 31, 30, 19));
            FixedStats.Add(new StatModel(72, 2924, 52, 28, 37, 31, 30, 19));
            FixedStats.Add(new StatModel(73, 2960, 52, 28, 37, 31, 30, 19));
            FixedStats.Add(new StatModel(74, 2995, 52, 28, 37, 31, 30, 19));
            FixedStats.Add(new StatModel(75, 3030, 53, 28, 38, 32, 31, 19));
            FixedStats.Add(new StatModel(76, 3065, 53, 28, 38, 32, 31, 19));
            FixedStats.Add(new StatModel(77, 3100, 53, 29, 38, 32, 31, 20));
            FixedStats.Add(new StatModel(78, 3135, 54, 29, 38, 32, 31, 20));
            FixedStats.Add(new StatModel(79, 3170, 54, 29, 38, 32, 31, 20));
            FixedStats.Add(new StatModel(80, 3205, 54, 29, 39, 33, 31, 20));
            FixedStats.Add(new StatModel(81, 3239, 54, 29, 39, 33, 31, 20));
            FixedStats.Add(new StatModel(82, 3274, 54, 29, 39, 33, 31, 20));
            FixedStats.Add(new StatModel(83, 3308, 55, 29, 39, 33, 31, 20));
            FixedStats.Add(new StatModel(84, 3343, 55, 29, 40, 33, 31, 20));
            FixedStats.Add(new StatModel(85, 3377, 55, 29, 40, 33, 32, 20));
            FixedStats.Add(new StatModel(86, 3411, 56, 29, 40, 33, 32, 20));
            FixedStats.Add(new StatModel(87, 3446, 56, 29, 40, 33, 32, 20));
            FixedStats.Add(new StatModel(88, 3480, 56, 30, 40, 33, 32, 20));
            FixedStats.Add(new StatModel(89, 3514, 56, 30, 41, 33, 32, 20));
            FixedStats.Add(new StatModel(90, 3548, 57, 30, 41, 34, 33, 20));
            FixedStats.Add(new StatModel(91, 3582, 57, 30, 41, 34, 33, 21));
            FixedStats.Add(new StatModel(92, 3616, 57, 30, 41, 34, 33, 21));
            FixedStats.Add(new StatModel(93, 3649, 57, 30, 41, 34, 33, 21));
            FixedStats.Add(new StatModel(94, 3683, 57, 30, 41, 34, 33, 21));
            FixedStats.Add(new StatModel(95, 3717, 57, 30, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(96, 3750, 58, 30, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(97, 3784, 58, 30, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(98, 3817, 58, 30, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(99, 3850, 58, 30, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(100, 3883, 58, 30, 42, 34, 34, 21));
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
