using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Squall : EnemyModel
    {
        public Squall() : base(180, "Squall")
        {
            PopulateStats();
        }

        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(07, 0486, 17, 06, 06, 05, 21, 16));
            FixedStats.Add(new StatModel(08, 0529, 17, 06, 07, 06, 21, 16));
            FixedStats.Add(new StatModel(09, 0572, 18, 07, 08, 06, 21, 16));
            FixedStats.Add(new StatModel(10, 0616, 19, 08, 08, 07, 22, 16));
            FixedStats.Add(new StatModel(11, 0659, 20, 08, 09, 08, 22, 16));
            FixedStats.Add(new StatModel(12, 0702, 20, 09, 10, 08, 22, 16));
            FixedStats.Add(new StatModel(13, 0745, 21, 09, 10, 09, 22, 16));
            FixedStats.Add(new StatModel(14, 0788, 22, 10, 11, 09, 22, 16));
            FixedStats.Add(new StatModel(15, 0831, 23, 11, 12, 10, 23, 16));
            FixedStats.Add(new StatModel(16, 0873, 23, 11, 12, 10, 23, 16));
            FixedStats.Add(new StatModel(17, 0916, 24, 12, 13, 11, 23, 16));
            FixedStats.Add(new StatModel(18, 0959, 24, 12, 14, 12, 23, 16));
            FixedStats.Add(new StatModel(19, 1001, 25, 13, 14, 12, 23, 16));
            FixedStats.Add(new StatModel(20, 1044, 26, 14, 15, 13, 24, 16));
            FixedStats.Add(new StatModel(21, 1086, 27, 14, 16, 13, 24, 17));
            FixedStats.Add(new StatModel(22, 1129, 27, 15, 16, 14, 24, 17));
            FixedStats.Add(new StatModel(23, 1171, 28, 15, 17, 14, 24, 17));
            FixedStats.Add(new StatModel(24, 1213, 28, 16, 18, 14, 24, 17));
            FixedStats.Add(new StatModel(25, 1255, 29, 17, 18, 15, 25, 17));
            FixedStats.Add(new StatModel(26, 1297, 30, 17, 19, 16, 25, 17));
            FixedStats.Add(new StatModel(27, 1339, 30, 18, 19, 16, 25, 17));
            FixedStats.Add(new StatModel(28, 1381, 31, 18, 20, 17, 25, 17));
            FixedStats.Add(new StatModel(29, 1423, 31, 18, 21, 17, 25, 17));
            FixedStats.Add(new StatModel(30, 1464, 32, 19, 21, 18, 25, 17));
            FixedStats.Add(new StatModel(31, 1506, 33, 20, 21, 18, 25, 17));
            FixedStats.Add(new StatModel(32, 1547, 33, 20, 22, 18, 25, 17));
            FixedStats.Add(new StatModel(33, 1589, 34, 20, 23, 19, 25, 17));
            FixedStats.Add(new StatModel(34, 1630, 34, 21, 23, 19, 25, 17));
            FixedStats.Add(new StatModel(35, 1671, 35, 22, 24, 20, 26, 18));
            FixedStats.Add(new StatModel(36, 1713, 36, 22, 24, 20, 26, 18));
            FixedStats.Add(new StatModel(37, 1754, 36, 23, 25, 21, 26, 18));
            FixedStats.Add(new StatModel(38, 1795, 37, 23, 25, 21, 26, 18));
            FixedStats.Add(new StatModel(39, 1836, 37, 23, 26, 21, 26, 18));
            FixedStats.Add(new StatModel(40, 1877, 38, 24, 27, 22, 27, 18));
            FixedStats.Add(new StatModel(41, 1918, 38, 24, 27, 22, 27, 18));
            FixedStats.Add(new StatModel(42, 1958, 39, 25, 27, 23, 27, 18));
            FixedStats.Add(new StatModel(43, 1999, 39, 25, 28, 23, 27, 18));
            FixedStats.Add(new StatModel(44, 2040, 40, 26, 29, 23, 27, 18));
            FixedStats.Add(new StatModel(45, 2080, 41, 26, 29, 24, 28, 18));
            FixedStats.Add(new StatModel(46, 2121, 41, 27, 29, 24, 28, 18));
            FixedStats.Add(new StatModel(47, 2161, 41, 27, 30, 25, 28, 18));
            FixedStats.Add(new StatModel(48, 2201, 42, 27, 30, 25, 28, 18));
            FixedStats.Add(new StatModel(49, 2241, 42, 28, 31, 25, 28, 18));
            FixedStats.Add(new StatModel(50, 2281, 43, 28, 31, 26, 29, 19));
            FixedStats.Add(new StatModel(51, 2321, 43, 29, 31, 26, 29, 19));
            FixedStats.Add(new StatModel(52, 2361, 44, 29, 32, 26, 29, 19));
            FixedStats.Add(new StatModel(53, 2401, 44, 29, 32, 27, 29, 19));
            FixedStats.Add(new StatModel(54, 2441, 45, 30, 33, 27, 29, 19));
            FixedStats.Add(new StatModel(55, 2481, 45, 30, 33, 28, 30, 19));
            FixedStats.Add(new StatModel(56, 2521, 46, 30, 34, 28, 30, 19));
            FixedStats.Add(new StatModel(57, 2560, 46, 31, 34, 28, 30, 19));
            FixedStats.Add(new StatModel(58, 2600, 46, 31, 34, 28, 30, 19));
            FixedStats.Add(new StatModel(59, 2639, 47, 31, 35, 28, 30, 19));
            FixedStats.Add(new StatModel(60, 2678, 47, 32, 35, 29, 30, 19));
            FixedStats.Add(new StatModel(61, 2718, 48, 32, 36, 29, 30, 19));
            FixedStats.Add(new StatModel(62, 2757, 48, 33, 36, 29, 30, 19));
            FixedStats.Add(new StatModel(63, 2796, 48, 33, 36, 30, 30, 20));
            FixedStats.Add(new StatModel(64, 2835, 49, 33, 37, 30, 30, 20));
            FixedStats.Add(new StatModel(65, 2874, 49, 34, 37, 30, 31, 20));
            FixedStats.Add(new StatModel(66, 2913, 50, 34, 37, 30, 31, 20));
            FixedStats.Add(new StatModel(67, 2951, 50, 34, 38, 31, 31, 20));
            FixedStats.Add(new StatModel(68, 2990, 50, 34, 38, 31, 31, 20));
            FixedStats.Add(new StatModel(69, 3029, 51, 34, 38, 31, 31, 20));
            FixedStats.Add(new StatModel(70, 3067, 51, 35, 39, 32, 32, 20));
            FixedStats.Add(new StatModel(71, 3106, 51, 35, 39, 32, 32, 20));
            FixedStats.Add(new StatModel(72, 3144, 52, 35, 39, 32, 32, 20));
            FixedStats.Add(new StatModel(73, 3183, 52, 36, 40, 32, 32, 20));
            FixedStats.Add(new StatModel(74, 3221, 52, 36, 40, 32, 32, 20));
            FixedStats.Add(new StatModel(75, 3259, 53, 36, 40, 33, 33, 20));
            FixedStats.Add(new StatModel(76, 3297, 53, 36, 40, 33, 33, 20));
            FixedStats.Add(new StatModel(77, 3335, 53, 37, 41, 33, 33, 21));
            FixedStats.Add(new StatModel(78, 3373, 53, 37, 41, 33, 33, 21));
            FixedStats.Add(new StatModel(79, 3411, 54, 37, 41, 33, 33, 21));
            FixedStats.Add(new StatModel(80, 3449, 54, 37, 42, 33, 34, 21));
            FixedStats.Add(new StatModel(81, 3486, 54, 37, 42, 33, 34, 21));
            FixedStats.Add(new StatModel(82, 3524, 55, 38, 42, 33, 34, 21));
            FixedStats.Add(new StatModel(83, 3561, 55, 38, 42, 34, 34, 21));
            FixedStats.Add(new StatModel(84, 3599, 55, 38, 43, 34, 34, 21));
            FixedStats.Add(new StatModel(85, 3636, 55, 38, 43, 34, 34, 21));
            FixedStats.Add(new StatModel(86, 3673, 56, 38, 43, 34, 35, 21));
            FixedStats.Add(new StatModel(87, 3711, 56, 39, 43, 34, 35, 21));
            FixedStats.Add(new StatModel(88, 3748, 56, 39, 43, 34, 35, 21));
            FixedStats.Add(new StatModel(89, 3785, 56, 39, 44, 34, 35, 21));
            FixedStats.Add(new StatModel(90, 3822, 57, 39, 44, 35, 35, 21));
            FixedStats.Add(new StatModel(91, 3859, 57, 39, 44, 35, 35, 22));
            FixedStats.Add(new StatModel(92, 3896, 57, 39, 44, 35, 35, 22));
            FixedStats.Add(new StatModel(93, 3932, 57, 39, 44, 35, 35, 22));
            FixedStats.Add(new StatModel(94, 3969, 57, 40, 44, 35, 35, 22));
            FixedStats.Add(new StatModel(95, 4006, 58, 40, 45, 35, 36, 22));
            FixedStats.Add(new StatModel(96, 4042, 58, 40, 45, 35, 36, 22));
            FixedStats.Add(new StatModel(97, 4079, 58, 40, 45, 35, 36, 22));
            FixedStats.Add(new StatModel(98, 4115, 58, 40, 45, 35, 36, 22));
            FixedStats.Add(new StatModel(99, 4151, 58, 40, 45, 35, 36, 22));
            FixedStats.Add(new StatModel(100, 4187, 58, 41, 45, 36, 37, 22));
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
