using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Selphie : EnemyModel
    {
        public Selphie() : base(182, "Selphie", new Element[] { }, new Element[] { })
        {

        }

        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 211, 1, 1, 5, 2, 15, 18));
            FixedStats.Add(new StatModel(2, 250, 2, 1, 6, 3, 15, 18));
            FixedStats.Add(new StatModel(3, 289, 2, 2, 6, 3, 15, 18));
            FixedStats.Add(new StatModel(4, 328, 3, 2, 7, 4, 16, 18));
            FixedStats.Add(new StatModel(5, 367, 4, 3, 8, 5, 16, 18));
            FixedStats.Add(new StatModel(6, 405, 5, 4, 8, 5, 16, 19));
            FixedStats.Add(new StatModel(7, 444, 5, 4, 9, 6, 16, 19));
            FixedStats.Add(new StatModel(8, 482, 6, 5, 10, 7, 17, 19));
            FixedStats.Add(new StatModel(9, 520, 7, 5, 10, 7, 17, 19));
            FixedStats.Add(new StatModel(10, 559, 7, 6, 11, 8, 17, 19));
            FixedStats.Add(new StatModel(11, 597, 8, 6, 11, 8, 17, 19));
            FixedStats.Add(new StatModel(12, 635, 9, 7, 12, 9, 18, 19));
            FixedStats.Add(new StatModel(13, 673, 9, 7, 13, 9, 18, 19));
            FixedStats.Add(new StatModel(14, 711, 10, 7, 13, 10, 18, 19));
            FixedStats.Add(new StatModel(15, 749, 11, 8, 14, 10, 18, 19));
            FixedStats.Add(new StatModel(16, 786, 11, 9, 14, 11, 19, 19));
            FixedStats.Add(new StatModel(17, 824, 12, 9, 15, 12, 19, 19));
            FixedStats.Add(new StatModel(18, 862, 13, 9, 16, 12, 19, 20));
            FixedStats.Add(new StatModel(19, 899, 13, 10, 16, 13, 19, 20));
            FixedStats.Add(new StatModel(20, 937, 14, 10, 17, 13, 20, 20));
            FixedStats.Add(new StatModel(21, 974, 14, 11, 17, 14, 20, 20));
            FixedStats.Add(new StatModel(22, 1012, 15, 11, 18, 14, 20, 20));
            FixedStats.Add(new StatModel(23, 1049, 16, 12, 18, 15, 20, 20));
            FixedStats.Add(new StatModel(24, 1086, 17, 12, 19, 15, 21, 20));
            FixedStats.Add(new StatModel(25, 1123, 17, 13, 20, 16, 21, 20));
            FixedStats.Add(new StatModel(26, 1160, 17, 13, 20, 16, 21, 20));
            FixedStats.Add(new StatModel(27, 1197, 18, 13, 20, 17, 21, 20));
            FixedStats.Add(new StatModel(28, 1234, 19, 14, 21, 17, 21, 20));
            FixedStats.Add(new StatModel(29, 1271, 19, 14, 21, 18, 21, 20));
            FixedStats.Add(new StatModel(30, 1307, 20, 15, 22, 18, 21, 21));
            FixedStats.Add(new StatModel(31, 1344, 20, 15, 23, 19, 21, 21));
            FixedStats.Add(new StatModel(32, 1380, 21, 15, 23, 19, 22, 21));
            FixedStats.Add(new StatModel(33, 1417, 22, 16, 24, 20, 22, 21));
            FixedStats.Add(new StatModel(34, 1453, 22, 16, 24, 20, 22, 21));
            FixedStats.Add(new StatModel(35, 1489, 23, 16, 25, 20, 22, 21));
            FixedStats.Add(new StatModel(36, 1526, 23, 17, 25, 21, 23, 21));
            FixedStats.Add(new StatModel(37, 1562, 24, 17, 26, 22, 23, 21));
            FixedStats.Add(new StatModel(38, 1598, 24, 17, 26, 22, 23, 21));
            FixedStats.Add(new StatModel(39, 1634, 25, 18, 27, 22, 23, 21));
            FixedStats.Add(new StatModel(40, 1670, 25, 18, 27, 23, 24, 21));
            FixedStats.Add(new StatModel(41, 1706, 25, 18, 28, 23, 24, 21));
            FixedStats.Add(new StatModel(42, 1741, 26, 19, 28, 23, 24, 22));
            FixedStats.Add(new StatModel(43, 1777, 27, 19, 29, 24, 24, 22));
            FixedStats.Add(new StatModel(44, 1813, 27, 19, 29, 24, 25, 22));
            FixedStats.Add(new StatModel(45, 1848, 28, 20, 30, 25, 25, 22));
            FixedStats.Add(new StatModel(46, 1884, 28, 20, 30, 25, 25, 22));
            FixedStats.Add(new StatModel(47, 1919, 28, 20, 30, 25, 25, 22));
            FixedStats.Add(new StatModel(48, 1954, 29, 20, 31, 26, 26, 22));
            FixedStats.Add(new StatModel(49, 1989, 30, 21, 31, 26, 26, 22));
            FixedStats.Add(new StatModel(50, 2024, 30, 21, 32, 27, 26, 22));
            FixedStats.Add(new StatModel(51, 2059, 30, 21, 32, 27, 26, 22));
            FixedStats.Add(new StatModel(52, 2094, 31, 22, 33, 27, 27, 22));
            FixedStats.Add(new StatModel(53, 2129, 31, 22, 33, 28, 27, 22));
            FixedStats.Add(new StatModel(54, 2164, 32, 22, 33, 28, 27, 23));
            FixedStats.Add(new StatModel(55, 2199, 32, 23, 34, 28, 27, 23));
            FixedStats.Add(new StatModel(56, 2234, 32, 23, 34, 29, 27, 23));
            FixedStats.Add(new StatModel(57, 2268, 33, 23, 35, 29, 27, 23));
            FixedStats.Add(new StatModel(58, 2303, 33, 23, 35, 29, 27, 23));
            FixedStats.Add(new StatModel(59, 2337, 34, 23, 35, 30, 27, 23));
            FixedStats.Add(new StatModel(60, 2371, 34, 24, 36, 30, 28, 23));
            FixedStats.Add(new StatModel(61, 2406, 34, 24, 36, 30, 28, 23));
            FixedStats.Add(new StatModel(62, 2440, 35, 24, 37, 31, 28, 23));
            FixedStats.Add(new StatModel(63, 2474, 35, 24, 37, 31, 28, 23));
            FixedStats.Add(new StatModel(64, 2508, 36, 24, 37, 31, 29, 23));
            FixedStats.Add(new StatModel(65, 2542, 36, 25, 38, 32, 29, 23));
            FixedStats.Add(new StatModel(66, 2576, 36, 25, 38, 32, 29, 24));
            FixedStats.Add(new StatModel(67, 2609, 37, 25, 39, 32, 29, 24));
            FixedStats.Add(new StatModel(68, 2643, 37, 25, 39, 32, 30, 24));
            FixedStats.Add(new StatModel(69, 2677, 37, 25, 39, 33, 30, 24));
            FixedStats.Add(new StatModel(70, 2710, 38, 26, 40, 33, 30, 24));
            FixedStats.Add(new StatModel(71, 2744, 38, 26, 40, 33, 30, 24));
            FixedStats.Add(new StatModel(72, 2777, 38, 26, 40, 33, 31, 24));
            FixedStats.Add(new StatModel(73, 2811, 39, 26, 41, 34, 31, 24));
            FixedStats.Add(new StatModel(74, 2844, 39, 26, 41, 34, 31, 24));
            FixedStats.Add(new StatModel(75, 2877, 39, 26, 42, 34, 31, 24));
            FixedStats.Add(new StatModel(76, 2910, 39, 27, 42, 34, 32, 24));
            FixedStats.Add(new StatModel(77, 2943, 40, 27, 42, 35, 32, 24));
            FixedStats.Add(new StatModel(78, 2976, 40, 27, 43, 35, 32, 25));
            FixedStats.Add(new StatModel(79, 3009, 40, 27, 43, 35, 32, 25));
            FixedStats.Add(new StatModel(80, 3042, 41, 27, 43, 35, 33, 25));
            FixedStats.Add(new StatModel(81, 3074, 41, 27, 44, 35, 33, 25));
            FixedStats.Add(new StatModel(82, 3107, 41, 27, 44, 35, 33, 25));
            FixedStats.Add(new StatModel(83, 3139, 41, 27, 44, 36, 33, 25));
            FixedStats.Add(new StatModel(84, 3172, 42, 27, 44, 36, 33, 25));
            FixedStats.Add(new StatModel(85, 3204, 42, 28, 45, 36, 33, 25));
            FixedStats.Add(new StatModel(86, 3236, 42, 28, 45, 36, 33, 25));
            FixedStats.Add(new StatModel(87, 3269, 42, 28, 45, 36, 33, 25));
            FixedStats.Add(new StatModel(88, 3301, 42, 28, 46, 37, 34, 25));
            FixedStats.Add(new StatModel(89, 3333, 43, 28, 46, 37, 34, 25));
            FixedStats.Add(new StatModel(90, 3365, 43, 28, 46, 37, 34, 26));
            FixedStats.Add(new StatModel(91, 3397, 43, 28, 46, 37, 34, 26));
            FixedStats.Add(new StatModel(92, 3429, 43, 28, 47, 37, 35, 26));
            FixedStats.Add(new StatModel(93, 3460, 44, 28, 47, 37, 35, 26));
            FixedStats.Add(new StatModel(94, 3492, 44, 28, 47, 37, 35, 26));
            FixedStats.Add(new StatModel(95, 3524, 44, 28, 48, 37, 35, 26));
            FixedStats.Add(new StatModel(96, 3555, 44, 28, 48, 38, 36, 26));
            FixedStats.Add(new StatModel(97, 3587, 44, 28, 48, 38, 36, 26));
            FixedStats.Add(new StatModel(98, 3618, 44, 28, 48, 38, 36, 26));
            FixedStats.Add(new StatModel(99, 3649, 45, 28, 48, 38, 36, 26));
            FixedStats.Add(new StatModel(100, 3680, 45, 28, 49, 38, 37, 26));
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
