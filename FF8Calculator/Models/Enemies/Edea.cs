using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Edea : EnemyModel
    {
        public Edea() : base(186, "Edea (Player)", new Element[] { }, new Element[] { })
        {
            PopulateStats();
        }

        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 209, 0, 0, 11, 8, 16, 10));
            FixedStats.Add(new StatModel(2, 249, 1, 0, 12, 8, 16, 10));
            FixedStats.Add(new StatModel(3, 289, 1, 0, 13, 9, 16, 10));
            FixedStats.Add(new StatModel(4, 329, 2, 1, 13, 10, 16, 10));
            FixedStats.Add(new StatModel(5, 369, 3, 1, 14, 10, 17, 10));
            FixedStats.Add(new StatModel(6, 408, 3, 1, 15, 11, 17, 10));
            FixedStats.Add(new StatModel(7, 448, 4, 2, 16, 12, 17, 10));
            FixedStats.Add(new StatModel(8, 487, 5, 2, 16, 12, 17, 10));
            FixedStats.Add(new StatModel(9, 526, 6, 2, 17, 13, 17, 10));
            FixedStats.Add(new StatModel(10, 566, 6, 2, 18, 14, 18, 11));
            FixedStats.Add(new StatModel(11, 605, 7, 3, 18, 14, 18, 11));
            FixedStats.Add(new StatModel(12, 644, 7, 3, 19, 15, 18, 11));
            FixedStats.Add(new StatModel(13, 683, 8, 3, 20, 15, 18, 11));
            FixedStats.Add(new StatModel(14, 722, 9, 4, 20, 16, 18, 11));
            FixedStats.Add(new StatModel(15, 761, 9, 4, 21, 17, 19, 11));
            FixedStats.Add(new StatModel(16, 799, 10, 4, 22, 17, 19, 11));
            FixedStats.Add(new StatModel(17, 838, 10, 4, 22, 18, 19, 11));
            FixedStats.Add(new StatModel(18, 877, 11, 4, 23, 19, 19, 11));
            FixedStats.Add(new StatModel(19, 915, 12, 5, 24, 19, 19, 11));
            FixedStats.Add(new StatModel(20, 954, 12, 5, 25, 20, 19, 11));
            FixedStats.Add(new StatModel(21, 992, 13, 5, 25, 20, 19, 11));
            FixedStats.Add(new StatModel(22, 1031, 13, 6, 26, 21, 19, 11));
            FixedStats.Add(new StatModel(23, 1069, 14, 6, 26, 21, 19, 11));
            FixedStats.Add(new StatModel(24, 1107, 14, 6, 27, 22, 19, 11));
            FixedStats.Add(new StatModel(25, 1145, 15, 6, 28, 22, 20, 11));
            FixedStats.Add(new StatModel(26, 1183, 15, 6, 28, 23, 20, 11));
            FixedStats.Add(new StatModel(27, 1221, 16, 7, 29, 23, 20, 11));
            FixedStats.Add(new StatModel(28, 1259, 17, 7, 29, 24, 20, 11));
            FixedStats.Add(new StatModel(29, 1297, 17, 7, 30, 24, 20, 11));
            FixedStats.Add(new StatModel(30, 1334, 18, 7, 31, 25, 21, 12));
            FixedStats.Add(new StatModel(31, 1372, 18, 8, 31, 25, 21, 12));
            FixedStats.Add(new StatModel(32, 1409, 19, 8, 31, 26, 21, 12));
            FixedStats.Add(new StatModel(33, 1447, 19, 8, 32, 26, 21, 12));
            FixedStats.Add(new StatModel(34, 1484, 20, 8, 32, 27, 21, 12));
            FixedStats.Add(new StatModel(35, 1521, 20, 9, 33, 27, 22, 12));
            FixedStats.Add(new StatModel(36, 1559, 21, 9, 34, 28, 22, 12));
            FixedStats.Add(new StatModel(37, 1596, 21, 9, 34, 28, 22, 12));
            FixedStats.Add(new StatModel(38, 1633, 22, 9, 35, 29, 22, 12));
            FixedStats.Add(new StatModel(39, 1670, 22, 9, 35, 29, 22, 12));
            FixedStats.Add(new StatModel(40, 1707, 23, 10, 36, 30, 22, 12));
            FixedStats.Add(new StatModel(41, 1744, 23, 10, 36, 30, 22, 12));
            FixedStats.Add(new StatModel(42, 1780, 24, 10, 37, 30, 22, 12));
            FixedStats.Add(new StatModel(43, 1817, 24, 10, 37, 31, 22, 12));
            FixedStats.Add(new StatModel(44, 1854, 24, 11, 38, 31, 22, 12));
            FixedStats.Add(new StatModel(45, 1890, 25, 11, 38, 32, 23, 12));
            FixedStats.Add(new StatModel(46, 1927, 25, 11, 39, 32, 23, 12));
            FixedStats.Add(new StatModel(47, 1963, 26, 11, 39, 32, 23, 12));
            FixedStats.Add(new StatModel(48, 1999, 26, 11, 39, 33, 23, 12));
            FixedStats.Add(new StatModel(49, 2035, 27, 12, 40, 33, 23, 12));
            FixedStats.Add(new StatModel(50, 2071, 27, 12, 41, 34, 24, 13));
            FixedStats.Add(new StatModel(51, 2107, 27, 12, 41, 34, 24, 13));
            FixedStats.Add(new StatModel(52, 2143, 28, 12, 41, 34, 24, 13));
            FixedStats.Add(new StatModel(53, 2179, 28, 12, 42, 35, 24, 13));
            FixedStats.Add(new StatModel(54, 2215, 29, 13, 42, 35, 24, 13));
            FixedStats.Add(new StatModel(55, 2251, 29, 13, 43, 36, 25, 13));
            FixedStats.Add(new StatModel(56, 2287, 29, 13, 43, 36, 25, 13));
            FixedStats.Add(new StatModel(57, 2322, 30, 13, 43, 36, 25, 13));
            FixedStats.Add(new StatModel(58, 2358, 30, 13, 44, 36, 25, 13));
            FixedStats.Add(new StatModel(59, 2393, 31, 14, 44, 37, 25, 13));
            FixedStats.Add(new StatModel(60, 2428, 31, 14, 45, 37, 25, 13));
            FixedStats.Add(new StatModel(61, 2464, 31, 14, 45, 37, 25, 13));
            FixedStats.Add(new StatModel(62, 2499, 32, 14, 45, 38, 25, 13));
            FixedStats.Add(new StatModel(63, 2534, 32, 14, 46, 38, 25, 13));
            FixedStats.Add(new StatModel(64, 2569, 32, 15, 46, 38, 25, 13));
            FixedStats.Add(new StatModel(65, 2604, 33, 15, 47, 39, 26, 13));
            FixedStats.Add(new StatModel(66, 2639, 33, 15, 47, 39, 26, 13));
            FixedStats.Add(new StatModel(67, 2673, 33, 15, 47, 39, 26, 13));
            FixedStats.Add(new StatModel(68, 2708, 33, 15, 47, 39, 26, 13));
            FixedStats.Add(new StatModel(69, 2743, 34, 15, 48, 40, 26, 13));
            FixedStats.Add(new StatModel(70, 2777, 34, 16, 48, 40, 27, 14));
            FixedStats.Add(new StatModel(71, 2812, 35, 16, 48, 40, 27, 14));
            FixedStats.Add(new StatModel(72, 2846, 35, 16, 49, 40, 27, 14));
            FixedStats.Add(new StatModel(73, 2881, 35, 16, 49, 41, 27, 14));
            FixedStats.Add(new StatModel(74, 2915, 35, 16, 49, 41, 27, 14));
            FixedStats.Add(new StatModel(75, 2949, 36, 16, 50, 41, 28, 14));
            FixedStats.Add(new StatModel(76, 2983, 36, 16, 50, 41, 28, 14));
            FixedStats.Add(new StatModel(77, 3017, 36, 17, 50, 41, 28, 14));
            FixedStats.Add(new StatModel(78, 3051, 36, 17, 50, 42, 28, 14));
            FixedStats.Add(new StatModel(79, 3085, 37, 17, 51, 42, 28, 14));
            FixedStats.Add(new StatModel(80, 3119, 37, 17, 51, 42, 28, 14));
            FixedStats.Add(new StatModel(81, 3152, 37, 17, 51, 42, 28, 14));
            FixedStats.Add(new StatModel(82, 3186, 37, 17, 51, 42, 28, 14));
            FixedStats.Add(new StatModel(83, 3219, 38, 18, 52, 43, 28, 14));
            FixedStats.Add(new StatModel(84, 3253, 38, 18, 52, 43, 28, 14));
            FixedStats.Add(new StatModel(85, 3286, 38, 18, 52, 43, 29, 14));
            FixedStats.Add(new StatModel(86, 3319, 38, 18, 52, 43, 29, 14));
            FixedStats.Add(new StatModel(87, 3353, 39, 18, 53, 43, 29, 14));
            FixedStats.Add(new StatModel(88, 3386, 39, 18, 53, 44, 29, 14));
            FixedStats.Add(new StatModel(89, 3419, 39, 18, 53, 44, 29, 14));
            FixedStats.Add(new StatModel(90, 3452, 39, 18, 54, 44, 30, 15));
            FixedStats.Add(new StatModel(91, 3485, 39, 19, 54, 44, 30, 15));
            FixedStats.Add(new StatModel(92, 3518, 40, 19, 54, 44, 30, 15));
            FixedStats.Add(new StatModel(93, 3550, 40, 19, 54, 44, 30, 15));
            FixedStats.Add(new StatModel(94, 3583, 40, 19, 54, 44, 30, 15));
            FixedStats.Add(new StatModel(95, 3616, 40, 19, 54, 44, 31, 15));
            FixedStats.Add(new StatModel(96, 3648, 40, 19, 54, 45, 31, 15));
            FixedStats.Add(new StatModel(97, 3681, 40, 19, 55, 45, 31, 15));
            FixedStats.Add(new StatModel(98, 3713, 41, 20, 55, 45, 31, 15));
            FixedStats.Add(new StatModel(99, 3745, 41, 20, 55, 45, 31, 15));
            FixedStats.Add(new StatModel(100, 3777, 41, 20, 55, 45, 31, 15));
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
