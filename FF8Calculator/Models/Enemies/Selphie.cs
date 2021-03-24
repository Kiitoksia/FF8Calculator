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
            PopulateStats();
        }

        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(08, 0482, 18, 05, 10, 07, 17, 19));
            FixedStats.Add(new StatModel(09, 0520, 19, 05, 10, 07, 17, 19));
            FixedStats.Add(new StatModel(10, 0559, 19, 06, 11, 08, 17, 19));
            FixedStats.Add(new StatModel(11, 0597, 20, 06, 11, 08, 17, 19));
            FixedStats.Add(new StatModel(12, 0635, 21, 07, 12, 09, 18, 19));
            FixedStats.Add(new StatModel(13, 0673, 21, 07, 13, 09, 18, 19));
            FixedStats.Add(new StatModel(14, 0711, 22, 07, 13, 10, 18, 19));
            FixedStats.Add(new StatModel(15, 0749, 23, 08, 14, 10, 18, 19));
            FixedStats.Add(new StatModel(16, 0786, 23, 09, 14, 11, 19, 19));
            FixedStats.Add(new StatModel(17, 0824, 24, 09, 15, 12, 19, 19));
            FixedStats.Add(new StatModel(18, 0862, 25, 09, 16, 12, 19, 20));
            FixedStats.Add(new StatModel(19, 0899, 25, 10, 16, 13, 19, 20));
            FixedStats.Add(new StatModel(20, 0937, 26, 10, 17, 13, 20, 20));
            FixedStats.Add(new StatModel(21, 0974, 26, 11, 17, 14, 20, 20));
            FixedStats.Add(new StatModel(22, 1012, 27, 11, 18, 14, 20, 20));
            FixedStats.Add(new StatModel(23, 1049, 28, 12, 18, 15, 20, 20));
            FixedStats.Add(new StatModel(24, 1086, 29, 12, 19, 15, 21, 20));
            FixedStats.Add(new StatModel(25, 1123, 29, 13, 20, 16, 21, 20));
            FixedStats.Add(new StatModel(26, 1160, 29, 13, 20, 16, 21, 20));
            FixedStats.Add(new StatModel(27, 1197, 30, 13, 20, 17, 21, 20));
            FixedStats.Add(new StatModel(28, 1234, 31, 14, 21, 17, 21, 20));
            FixedStats.Add(new StatModel(29, 1271, 31, 14, 21, 18, 21, 20));
            FixedStats.Add(new StatModel(30, 1307, 32, 15, 22, 18, 21, 21));
            FixedStats.Add(new StatModel(31, 1344, 32, 15, 23, 19, 21, 21));
            FixedStats.Add(new StatModel(32, 1380, 33, 15, 23, 19, 22, 21));
            FixedStats.Add(new StatModel(33, 1417, 34, 16, 24, 20, 22, 21));
            FixedStats.Add(new StatModel(34, 1453, 34, 16, 24, 20, 22, 21));
            FixedStats.Add(new StatModel(35, 1489, 35, 16, 25, 20, 22, 21));
            FixedStats.Add(new StatModel(36, 1526, 35, 17, 25, 21, 23, 21));
            FixedStats.Add(new StatModel(37, 1562, 36, 17, 26, 22, 23, 21));
            FixedStats.Add(new StatModel(38, 1598, 36, 17, 26, 22, 23, 21));
            FixedStats.Add(new StatModel(39, 1634, 37, 18, 27, 22, 23, 21));
            FixedStats.Add(new StatModel(40, 1670, 37, 18, 27, 23, 24, 21));
            FixedStats.Add(new StatModel(41, 1706, 37, 18, 28, 23, 24, 21));
            FixedStats.Add(new StatModel(42, 1741, 38, 19, 28, 23, 24, 22));
            FixedStats.Add(new StatModel(43, 1777, 39, 19, 29, 24, 24, 22));
            FixedStats.Add(new StatModel(44, 1813, 39, 19, 29, 24, 25, 22));
            FixedStats.Add(new StatModel(45, 1848, 40, 20, 30, 25, 25, 22));
            FixedStats.Add(new StatModel(46, 1884, 40, 20, 30, 25, 25, 22));
            FixedStats.Add(new StatModel(47, 1919, 40, 20, 30, 25, 25, 22));
            FixedStats.Add(new StatModel(48, 1954, 41, 20, 31, 26, 26, 22));
            FixedStats.Add(new StatModel(49, 1989, 42, 21, 31, 26, 26, 22));
            FixedStats.Add(new StatModel(50, 2024, 42, 21, 32, 27, 26, 22));
            FixedStats.Add(new StatModel(51, 2059, 42, 21, 32, 27, 26, 22));
            FixedStats.Add(new StatModel(52, 2094, 43, 22, 33, 27, 27, 22));
            FixedStats.Add(new StatModel(53, 2129, 43, 22, 33, 28, 27, 22));
            FixedStats.Add(new StatModel(54, 2164, 44, 22, 33, 28, 27, 23));
            FixedStats.Add(new StatModel(55, 2199, 44, 23, 34, 28, 27, 23));
            FixedStats.Add(new StatModel(56, 2234, 44, 23, 34, 29, 27, 23));
            FixedStats.Add(new StatModel(57, 2268, 45, 23, 35, 29, 27, 23));
            FixedStats.Add(new StatModel(58, 2303, 45, 23, 35, 29, 27, 23));
            FixedStats.Add(new StatModel(59, 2337, 46, 23, 35, 30, 27, 23));
            FixedStats.Add(new StatModel(60, 2371, 46, 24, 36, 30, 28, 23));
            FixedStats.Add(new StatModel(61, 2406, 46, 24, 36, 30, 28, 23));
            FixedStats.Add(new StatModel(62, 2440, 47, 24, 37, 31, 28, 23));
            FixedStats.Add(new StatModel(63, 2474, 47, 24, 37, 31, 28, 23));
            FixedStats.Add(new StatModel(64, 2508, 48, 24, 37, 31, 29, 23));
            FixedStats.Add(new StatModel(65, 2542, 48, 25, 38, 32, 29, 23));
            FixedStats.Add(new StatModel(66, 2576, 48, 25, 38, 32, 29, 24));
            FixedStats.Add(new StatModel(67, 2609, 49, 25, 39, 32, 29, 24));
            FixedStats.Add(new StatModel(68, 2643, 49, 25, 39, 32, 30, 24));
            FixedStats.Add(new StatModel(69, 2677, 49, 25, 39, 33, 30, 24));
            FixedStats.Add(new StatModel(70, 2710, 50, 26, 40, 33, 30, 24));
            FixedStats.Add(new StatModel(71, 2744, 50, 26, 40, 33, 30, 24));
            FixedStats.Add(new StatModel(72, 2777, 50, 26, 40, 33, 31, 24));
            FixedStats.Add(new StatModel(73, 2811, 51, 26, 41, 34, 31, 24));
            FixedStats.Add(new StatModel(74, 2844, 51, 26, 41, 34, 31, 24));
            FixedStats.Add(new StatModel(75, 2877, 51, 26, 42, 34, 31, 24));
            FixedStats.Add(new StatModel(76, 2910, 51, 27, 42, 34, 32, 24));
            FixedStats.Add(new StatModel(77, 2943, 52, 27, 42, 35, 32, 24));
            FixedStats.Add(new StatModel(78, 2976, 52, 27, 43, 35, 32, 25));
            FixedStats.Add(new StatModel(79, 3009, 52, 27, 43, 35, 32, 25));
            FixedStats.Add(new StatModel(80, 3042, 53, 27, 43, 35, 33, 25));
            FixedStats.Add(new StatModel(81, 3074, 53, 27, 44, 35, 33, 25));
            FixedStats.Add(new StatModel(82, 3107, 53, 27, 44, 35, 33, 25));
            FixedStats.Add(new StatModel(83, 3139, 53, 27, 44, 36, 33, 25));
            FixedStats.Add(new StatModel(84, 3172, 54, 27, 44, 36, 33, 25));
            FixedStats.Add(new StatModel(85, 3204, 54, 28, 45, 36, 33, 25));
            FixedStats.Add(new StatModel(86, 3236, 54, 28, 45, 36, 33, 25));
            FixedStats.Add(new StatModel(87, 3269, 54, 28, 45, 36, 33, 25));
            FixedStats.Add(new StatModel(88, 3301, 54, 28, 46, 37, 34, 25));
            FixedStats.Add(new StatModel(89, 3333, 55, 28, 46, 37, 34, 25));
            FixedStats.Add(new StatModel(90, 3365, 55, 28, 46, 37, 34, 26));
            FixedStats.Add(new StatModel(91, 3397, 55, 28, 46, 37, 34, 26));
            FixedStats.Add(new StatModel(92, 3429, 55, 28, 47, 37, 35, 26));
            FixedStats.Add(new StatModel(93, 3460, 56, 28, 47, 37, 35, 26));
            FixedStats.Add(new StatModel(94, 3492, 56, 28, 47, 37, 35, 26));
            FixedStats.Add(new StatModel(95, 3524, 56, 28, 48, 37, 35, 26));
            FixedStats.Add(new StatModel(96, 3555, 56, 28, 48, 38, 36, 26));
            FixedStats.Add(new StatModel(97, 3587, 56, 28, 48, 38, 36, 26));
            FixedStats.Add(new StatModel(98, 3618, 56, 28, 48, 38, 36, 26));
            FixedStats.Add(new StatModel(99, 3649, 57, 28, 48, 38, 36, 26));
            FixedStats.Add(new StatModel(100, 3680, 57, 28, 49, 38, 37, 26));
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
