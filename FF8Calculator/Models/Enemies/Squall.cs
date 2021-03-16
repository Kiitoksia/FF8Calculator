using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Squall : EnemyModel
    {
        public Squall() : base(180, "Squall", new Element[] { }, new Element[] { })
        {
            PopulateStats();
        }

        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 223, 1, 1, 2, 1, 20, 15));
            FixedStats.Add(new StatModel(2, 267, 2, 2, 2, 2, 20, 15));
            FixedStats.Add(new StatModel(3, 311, 2, 3, 3, 3, 20, 15));
            FixedStats.Add(new StatModel(4, 355, 3, 3, 4, 3, 20, 15));
            FixedStats.Add(new StatModel(5, 399, 4, 4, 5, 4, 21, 15));
            FixedStats.Add(new StatModel(6, 442, 5, 5, 5, 5, 21, 15));
            FixedStats.Add(new StatModel(7, 486, 6, 6, 6, 5, 21, 16));
            FixedStats.Add(new StatModel(8, 529, 6, 6, 7, 6, 21, 16));
            FixedStats.Add(new StatModel(9, 572, 7, 7, 8, 6, 21, 16));
            FixedStats.Add(new StatModel(10, 616, 8, 8, 8, 7, 22, 16));
            FixedStats.Add(new StatModel(11, 659, 9, 8, 9, 8, 22, 16));
            FixedStats.Add(new StatModel(12, 702, 9, 9, 10, 8, 22, 16));
            FixedStats.Add(new StatModel(13, 745, 10, 9, 10, 9, 22, 16));
            FixedStats.Add(new StatModel(14, 788, 11, 10, 11, 9, 22, 16));
            FixedStats.Add(new StatModel(15, 831, 12, 11, 12, 10, 23, 16));
            FixedStats.Add(new StatModel(16, 873, 12, 11, 12, 10, 23, 16));
            FixedStats.Add(new StatModel(17, 916, 13, 12, 13, 11, 23, 16));
            FixedStats.Add(new StatModel(18, 959, 13, 12, 14, 12, 23, 16));
            FixedStats.Add(new StatModel(19, 1001, 14, 13, 14, 12, 23, 16));
            FixedStats.Add(new StatModel(20, 1044, 15, 14, 15, 13, 24, 16));
            FixedStats.Add(new StatModel(21, 1086, 16, 14, 16, 13, 24, 17));
            FixedStats.Add(new StatModel(22, 1129, 16, 15, 16, 14, 24, 17));
            FixedStats.Add(new StatModel(23, 1171, 17, 15, 17, 14, 24, 17));
            FixedStats.Add(new StatModel(24, 1213, 17, 16, 18, 14, 24, 17));
            FixedStats.Add(new StatModel(25, 1255, 18, 17, 18, 15, 25, 17));
            FixedStats.Add(new StatModel(26, 1297, 19, 17, 19, 16, 25, 17));
            FixedStats.Add(new StatModel(27, 1339, 19, 18, 19, 16, 25, 17));
            FixedStats.Add(new StatModel(28, 1381, 20, 18, 20, 17, 25, 17));
            FixedStats.Add(new StatModel(29, 1423, 20, 18, 21, 17, 25, 17));
            FixedStats.Add(new StatModel(30, 1464, 21, 19, 21, 18, 25, 17));
            FixedStats.Add(new StatModel(31, 1506, 22, 20, 21, 18, 25, 17));
            FixedStats.Add(new StatModel(32, 1547, 22, 20, 22, 18, 25, 17));
            FixedStats.Add(new StatModel(33, 1589, 23, 20, 23, 19, 25, 17));
            FixedStats.Add(new StatModel(34, 1630, 23, 21, 23, 19, 25, 17));
            FixedStats.Add(new StatModel(35, 1671, 24, 22, 24, 20, 26, 18));
            FixedStats.Add(new StatModel(36, 1713, 25, 22, 24, 20, 26, 18));
            FixedStats.Add(new StatModel(37, 1754, 25, 23, 25, 21, 26, 18));
            FixedStats.Add(new StatModel(38, 1795, 26, 23, 25, 21, 26, 18));
            FixedStats.Add(new StatModel(39, 1836, 26, 23, 26, 21, 26, 18));
            FixedStats.Add(new StatModel(40, 1877, 27, 24, 27, 22, 27, 18));
            FixedStats.Add(new StatModel(41, 1918, 27, 24, 27, 22, 27, 18));
            FixedStats.Add(new StatModel(42, 1958, 28, 25, 27, 23, 27, 18));
            FixedStats.Add(new StatModel(43, 1999, 28, 25, 28, 23, 27, 18));
            FixedStats.Add(new StatModel(44, 2040, 29, 26, 29, 23, 27, 18));
            FixedStats.Add(new StatModel(45, 2080, 30, 26, 29, 24, 28, 18));
            FixedStats.Add(new StatModel(46, 2121, 30, 27, 29, 24, 28, 18));
            FixedStats.Add(new StatModel(47, 2161, 30, 27, 30, 25, 28, 18));
            FixedStats.Add(new StatModel(48, 2201, 31, 27, 30, 25, 28, 18));
            FixedStats.Add(new StatModel(49, 2241, 31, 28, 31, 25, 28, 19));
            FixedStats.Add(new StatModel(50, 2281, 32, 28, 31, 26, 29, 19));
            FixedStats.Add(new StatModel(51, 2321, 32, 29, 31, 26, 29, 19));
            FixedStats.Add(new StatModel(52, 2361, 33, 29, 32, 26, 29, 19));
            FixedStats.Add(new StatModel(53, 2401, 33, 29, 32, 27, 29, 19));
            FixedStats.Add(new StatModel(54, 2441, 34, 30, 33, 27, 29, 19));
            FixedStats.Add(new StatModel(55, 2481, 34, 30, 33, 28, 30, 19));
            FixedStats.Add(new StatModel(56, 2521, 35, 30, 34, 28, 30, 19));
            FixedStats.Add(new StatModel(57, 2560, 35, 31, 34, 28, 30, 19));
            FixedStats.Add(new StatModel(58, 2600, 35, 31, 34, 28, 30, 19));
            FixedStats.Add(new StatModel(59, 2639, 36, 31, 35, 28, 30, 19));
            FixedStats.Add(new StatModel(60, 2678, 36, 32, 35, 29, 30, 19));
            FixedStats.Add(new StatModel(61, 2718, 37, 32, 36, 29, 30, 19));
            FixedStats.Add(new StatModel(62, 2757, 37, 33, 36, 29, 30, 19));
            FixedStats.Add(new StatModel(63, 2796, 37, 33, 36, 30, 30, 20));
            FixedStats.Add(new StatModel(64, 2835, 38, 33, 37, 30, 30, 20));
            FixedStats.Add(new StatModel(65, 2874, 38, 34, 37, 30, 31, 20));
            FixedStats.Add(new StatModel(66, 2913, 39, 34, 37, 30, 31, 20));
            FixedStats.Add(new StatModel(67, 2951, 39, 34, 38, 31, 31, 20));
            FixedStats.Add(new StatModel(68, 2990, 39, 34, 38, 31, 31, 20));
            FixedStats.Add(new StatModel(69, 3029, 40, 34, 38, 31, 31, 20));
            FixedStats.Add(new StatModel(70, 3067, 40, 35, 39, 32, 32, 20));
            FixedStats.Add(new StatModel(71, 3106, 40, 35, 39, 32, 32, 20));
            FixedStats.Add(new StatModel(72, 3144, 41, 35, 39, 32, 32, 20));
            FixedStats.Add(new StatModel(73, 3183, 41, 36, 40, 32, 32, 20));
            FixedStats.Add(new StatModel(74, 3221, 41, 36, 40, 32, 32, 20));
            FixedStats.Add(new StatModel(75, 3259, 42, 36, 40, 33, 33, 20));
            FixedStats.Add(new StatModel(76, 3297, 42, 36, 40, 33, 33, 20));
            FixedStats.Add(new StatModel(77, 3335, 42, 37, 41, 33, 33, 21));
            FixedStats.Add(new StatModel(78, 3373, 42, 37, 41, 33, 33, 21));
            FixedStats.Add(new StatModel(79, 3411, 43, 37, 41, 33, 33, 21));
            FixedStats.Add(new StatModel(80, 3449, 43, 37, 42, 33, 34, 21));
            FixedStats.Add(new StatModel(81, 3486, 43, 37, 42, 33, 34, 21));
            FixedStats.Add(new StatModel(82, 3524, 44, 38, 42, 33, 34, 21));
            FixedStats.Add(new StatModel(83, 3561, 44, 38, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(84, 3599, 44, 38, 43, 34, 34, 21));
            FixedStats.Add(new StatModel(85, 3636, 44, 38, 43, 34, 35, 21));
            FixedStats.Add(new StatModel(86, 3673, 45, 38, 43, 34, 35, 21));
            FixedStats.Add(new StatModel(87, 3711, 45, 39, 43, 34, 35, 21));
            FixedStats.Add(new StatModel(88, 3748, 45, 39, 43, 34, 35, 21));
            FixedStats.Add(new StatModel(89, 3785, 45, 39, 44, 34, 35, 21));
            FixedStats.Add(new StatModel(90, 3822, 46, 39, 44, 35, 35, 21));
            FixedStats.Add(new StatModel(91, 3859, 46, 39, 44, 35, 35, 22));
            FixedStats.Add(new StatModel(92, 3896, 46, 39, 44, 35, 35, 22));
            FixedStats.Add(new StatModel(93, 3932, 46, 39, 44, 35, 35, 22));
            FixedStats.Add(new StatModel(94, 3969, 46, 40, 44, 35, 35, 22));
            FixedStats.Add(new StatModel(95, 4006, 47, 40, 45, 35, 36, 22));
            FixedStats.Add(new StatModel(96, 4042, 47, 40, 45, 35, 36, 22));
            FixedStats.Add(new StatModel(97, 4079, 47, 40, 45, 35, 36, 22));
            FixedStats.Add(new StatModel(98, 4115, 47, 40, 45, 35, 36, 22));
            FixedStats.Add(new StatModel(99, 4151, 47, 40, 45, 35, 36, 22));
            FixedStats.Add(new StatModel(100, 4187, 47, 41, 45, 36, 37, 22));
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
