using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Rinoa : EnemyModel
    {
        public Rinoa() : base(185, "Rinoa")
        {
            PopulateStats();
        }


        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(11, 0653, 22, 05, 15, 09, 22, 17));
            FixedStats.Add(new StatModel(12, 0696, 23, 06, 16, 10, 22, 17));
            FixedStats.Add(new StatModel(13, 0739, 24, 06, 17, 10, 22, 17));
            FixedStats.Add(new StatModel(14, 0782, 25, 07, 17, 11, 22, 17));
            FixedStats.Add(new StatModel(15, 0825, 26, 08, 18, 11, 23, 17));
            FixedStats.Add(new StatModel(16, 0867, 26, 08, 19, 12, 23, 17));
            FixedStats.Add(new StatModel(17, 0910, 27, 08, 20, 12, 23, 17));
            FixedStats.Add(new StatModel(18, 0953, 28, 09, 20, 13, 23, 17));
            FixedStats.Add(new StatModel(19, 0995, 29, 09, 21, 13, 23, 17));
            FixedStats.Add(new StatModel(20, 1038, 30, 10, 22, 14, 24, 17));
            FixedStats.Add(new StatModel(21, 1080, 31, 10, 22, 14, 24, 17));
            FixedStats.Add(new StatModel(22, 1123, 31, 10, 23, 15, 24, 17));
            FixedStats.Add(new StatModel(23, 1165, 32, 11, 24, 15, 24, 17));
            FixedStats.Add(new StatModel(24, 1207, 33, 11, 24, 16, 24, 18));
            FixedStats.Add(new StatModel(25, 1249, 34, 12, 25, 16, 24, 18));
            FixedStats.Add(new StatModel(26, 1291, 35, 12, 26, 17, 24, 18));
            FixedStats.Add(new StatModel(27, 1333, 36, 13, 26, 17, 24, 18));
            FixedStats.Add(new StatModel(28, 1375, 36, 13, 27, 18, 24, 18));
            FixedStats.Add(new StatModel(29, 1417, 37, 13, 28, 18, 24, 18));
            FixedStats.Add(new StatModel(30, 1458, 38, 14, 29, 19, 25, 18));
            FixedStats.Add(new StatModel(31, 1500, 39, 14, 29, 20, 25, 18));
            FixedStats.Add(new StatModel(32, 1541, 40, 15, 30, 20, 25, 18));
            FixedStats.Add(new StatModel(33, 1583, 41, 15, 30, 20, 25, 18));
            FixedStats.Add(new StatModel(34, 1624, 41, 15, 31, 21, 25, 18));
            FixedStats.Add(new StatModel(35, 1665, 42, 16, 32, 21, 26, 18));
            FixedStats.Add(new StatModel(36, 1707, 43, 16, 32, 22, 26, 18));
            FixedStats.Add(new StatModel(37, 1748, 44, 16, 33, 22, 26, 18));
            FixedStats.Add(new StatModel(38, 1789, 44, 17, 33, 23, 26, 18));
            FixedStats.Add(new StatModel(39, 1830, 45, 17, 34, 23, 26, 18));
            FixedStats.Add(new StatModel(40, 1871, 46, 18, 35, 24, 27, 19));
            FixedStats.Add(new StatModel(41, 1912, 46, 18, 35, 24, 27, 19));
            FixedStats.Add(new StatModel(42, 1952, 47, 18, 36, 24, 27, 19));
            FixedStats.Add(new StatModel(43, 1993, 48, 18, 36, 25, 27, 19));
            FixedStats.Add(new StatModel(44, 2034, 49, 19, 37, 25, 27, 19));
            FixedStats.Add(new StatModel(45, 2074, 50, 19, 38, 25, 28, 19));
            FixedStats.Add(new StatModel(46, 2115, 50, 20, 38, 26, 28, 19));
            FixedStats.Add(new StatModel(47, 2155, 51, 20, 39, 26, 28, 19));
            FixedStats.Add(new StatModel(48, 2195, 52, 20, 39, 27, 28, 19));
            FixedStats.Add(new StatModel(49, 2235, 52, 20, 40, 27, 28, 19));
            FixedStats.Add(new StatModel(50, 2275, 53, 21, 41, 28, 28, 19));
            FixedStats.Add(new StatModel(51, 2315, 53, 21, 41, 28, 28, 19));
            FixedStats.Add(new StatModel(52, 2355, 54, 21, 41, 28, 28, 19));
            FixedStats.Add(new StatModel(53, 2395, 55, 22, 42, 29, 28, 19));
            FixedStats.Add(new StatModel(54, 2435, 56, 22, 42, 29, 28, 19));
            FixedStats.Add(new StatModel(55, 2475, 56, 22, 43, 29, 29, 19));
            FixedStats.Add(new StatModel(56, 2515, 57, 23, 44, 30, 29, 20));
            FixedStats.Add(new StatModel(57, 2554, 57, 23, 44, 30, 29, 20));
            FixedStats.Add(new StatModel(58, 2594, 58, 23, 45, 30, 29, 20));
            FixedStats.Add(new StatModel(59, 2633, 59, 23, 45, 30, 29, 20));
            FixedStats.Add(new StatModel(60, 2672, 59, 24, 46, 31, 30, 20));
            FixedStats.Add(new StatModel(61, 2712, 60, 24, 46, 31, 30, 20));
            FixedStats.Add(new StatModel(62, 2751, 60, 24, 47, 32, 30, 20));
            FixedStats.Add(new StatModel(63, 2790, 61, 24, 47, 32, 30, 20));
            FixedStats.Add(new StatModel(64, 2829, 62, 25, 48, 32, 30, 20));
            FixedStats.Add(new StatModel(65, 2868, 62, 25, 48, 32, 31, 20));
            FixedStats.Add(new StatModel(66, 2907, 63, 25, 49, 33, 31, 20));
            FixedStats.Add(new StatModel(67, 2945, 63, 25, 49, 33, 31, 20));
            FixedStats.Add(new StatModel(68, 2984, 64, 26, 50, 33, 31, 20));
            FixedStats.Add(new StatModel(69, 3023, 64, 26, 50, 33, 31, 20));
            FixedStats.Add(new StatModel(70, 3061, 65, 26, 51, 34, 32, 20));
            FixedStats.Add(new StatModel(71, 3100, 65, 26, 51, 34, 32, 20));
            FixedStats.Add(new StatModel(72, 3183, 66, 26, 51, 34, 32, 21));
            FixedStats.Add(new StatModel(73, 3177, 67, 27, 52, 34, 32, 21));
            FixedStats.Add(new StatModel(74, 3215, 67, 27, 52, 35, 32, 21));
            FixedStats.Add(new StatModel(75, 3253, 68, 27, 53, 35, 32, 21));
            FixedStats.Add(new StatModel(76, 3291, 68, 27, 53, 35, 32, 21));
            FixedStats.Add(new StatModel(77, 3329, 68, 27, 54, 35, 32, 21));
            FixedStats.Add(new StatModel(78, 3367, 69, 28, 54, 35, 32, 21));
            FixedStats.Add(new StatModel(79, 3405, 70, 28, 55, 36, 32, 21));
            FixedStats.Add(new StatModel(80, 3443, 70, 28, 55, 36, 33, 21));
            FixedStats.Add(new StatModel(81, 3480, 70, 28, 55, 36, 33, 21));
            FixedStats.Add(new StatModel(82, 3518, 71, 28, 56, 36, 33, 21));
            FixedStats.Add(new StatModel(83, 3555, 71, 28, 56, 36, 33, 21));
            FixedStats.Add(new StatModel(84, 3593, 72, 29, 57, 37, 33, 21));
            FixedStats.Add(new StatModel(85, 3630, 73, 29, 57, 37, 34, 21));
            FixedStats.Add(new StatModel(86, 3667, 73, 29, 58, 37, 34, 21));
            FixedStats.Add(new StatModel(87, 3705, 73, 29, 58, 37, 34, 21));
            FixedStats.Add(new StatModel(88, 3742, 84, 30, 58, 37, 34, 22));
            FixedStats.Add(new StatModel(89, 3779, 84, 30, 59, 37, 34, 22));
            FixedStats.Add(new StatModel(90, 3816, 75, 30, 59, 38, 35, 22));
            FixedStats.Add(new StatModel(91, 3853, 75, 30, 59, 38, 35, 22));
            FixedStats.Add(new StatModel(92, 3890, 75, 30, 60, 38, 35, 22));
            FixedStats.Add(new StatModel(93, 3926, 76, 30, 60, 38, 35, 22));
            FixedStats.Add(new StatModel(94, 3963, 76, 30, 60, 38, 35, 22));
            FixedStats.Add(new StatModel(95, 4000, 77, 30, 61, 38, 36, 22));
            FixedStats.Add(new StatModel(96, 4036, 77, 30, 61, 38, 36, 22));
            FixedStats.Add(new StatModel(97, 4073, 77, 30, 62, 38, 36, 22));
            FixedStats.Add(new StatModel(98, 4109, 78, 30, 62, 38, 36, 22));
            FixedStats.Add(new StatModel(99, 4145, 78, 31, 62, 38, 36, 22));
            FixedStats.Add(new StatModel(100, 4181, 78, 31, 63, 39, 36, 22));
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
