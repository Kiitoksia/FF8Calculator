using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Rinoa : EnemyModel
    {
        public Rinoa() : base(185, "Rinoa", new Element[] { }, new Element[] { })
        {
            PopulateStats();
        }


        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 217, 1, 0, 8, 3, 20, 16));
            FixedStats.Add(new StatModel(2, 261, 2, 1, 8, 3, 20, 16));
            FixedStats.Add(new StatModel(3, 305, 3, 1, 9, 4, 20, 16));
            FixedStats.Add(new StatModel(4, 349, 4, 2, 10, 5, 20, 16));
            FixedStats.Add(new StatModel(5, 393, 5, 3, 11, 5, 21, 16));
            FixedStats.Add(new StatModel(6, 436, 6, 3, 12, 6, 21, 16));
            FixedStats.Add(new StatModel(7, 480, 7, 4, 12, 6, 21, 16));
            FixedStats.Add(new StatModel(8, 523, 8, 4, 13, 7, 21, 17));
            FixedStats.Add(new StatModel(9, 566, 9, 5, 14, 8, 21, 17));
            FixedStats.Add(new StatModel(10, 610, 10, 5, 15, 8, 22, 17));
            FixedStats.Add(new StatModel(11, 653, 11, 5, 15, 9, 22, 17));
            FixedStats.Add(new StatModel(12, 696, 12, 6, 16, 10, 22, 17));
            FixedStats.Add(new StatModel(13, 739, 13, 6, 17, 10, 22, 17));
            FixedStats.Add(new StatModel(14, 782, 14, 7, 17, 11, 22, 17));
            FixedStats.Add(new StatModel(15, 825, 15, 8, 18, 11, 23, 17));
            FixedStats.Add(new StatModel(16, 867, 15, 8, 19, 12, 23, 17));
            FixedStats.Add(new StatModel(17, 910, 16, 8, 20, 12, 23, 17));
            FixedStats.Add(new StatModel(18, 953, 17, 9, 20, 13, 23, 17));
            FixedStats.Add(new StatModel(19, 995, 18, 9, 21, 13, 23, 17));
            FixedStats.Add(new StatModel(20, 1038, 19, 10, 22, 14, 24, 17));
            FixedStats.Add(new StatModel(21, 1080, 20, 10, 22, 14, 24, 17));
            FixedStats.Add(new StatModel(22, 1123, 20, 10, 23, 15, 24, 17));
            FixedStats.Add(new StatModel(23, 1165, 21, 11, 24, 15, 24, 17));
            FixedStats.Add(new StatModel(24, 1207, 22, 11, 24, 16, 24, 18));
            FixedStats.Add(new StatModel(25, 1249, 23, 12, 25, 16, 24, 18));
            FixedStats.Add(new StatModel(26, 1291, 24, 12, 26, 17, 24, 18));
            FixedStats.Add(new StatModel(27, 1333, 25, 13, 26, 17, 24, 18));
            FixedStats.Add(new StatModel(28, 1375, 25, 13, 27, 18, 24, 18));
            FixedStats.Add(new StatModel(29, 1417, 26, 13, 28, 18, 24, 18));
            FixedStats.Add(new StatModel(30, 1458, 27, 14, 29, 19, 25, 18));
            FixedStats.Add(new StatModel(31, 1500, 28, 14, 29, 20, 25, 18));
            FixedStats.Add(new StatModel(32, 1541, 29, 15, 30, 20, 25, 18));
            FixedStats.Add(new StatModel(33, 1583, 30, 15, 30, 20, 25, 18));
            FixedStats.Add(new StatModel(34, 1624, 30, 15, 31, 21, 25, 18));
            FixedStats.Add(new StatModel(35, 1665, 31, 16, 32, 21, 26, 18));
            FixedStats.Add(new StatModel(36, 1707, 32, 16, 32, 22, 26, 18));
            FixedStats.Add(new StatModel(37, 1748, 33, 16, 33, 22, 26, 18));
            FixedStats.Add(new StatModel(38, 1789, 33, 17, 33, 23, 26, 18));
            FixedStats.Add(new StatModel(39, 1830, 34, 17, 34, 23, 26, 18));
            FixedStats.Add(new StatModel(40, 1871, 35, 18, 35, 24, 27, 19));
            FixedStats.Add(new StatModel(41, 1912, 35, 18, 35, 24, 27, 19));
            FixedStats.Add(new StatModel(42, 1952, 36, 18, 36, 24, 27, 19));
            FixedStats.Add(new StatModel(43, 1993, 37, 18, 36, 25, 27, 19));
            FixedStats.Add(new StatModel(44, 2034, 38, 19, 37, 25, 27, 19));
            FixedStats.Add(new StatModel(45, 2074, 39, 19, 38, 25, 28, 19));
            FixedStats.Add(new StatModel(46, 2115, 39, 20, 38, 26, 28, 19));
            FixedStats.Add(new StatModel(47, 2155, 40, 20, 39, 26, 28, 19));
            FixedStats.Add(new StatModel(48, 2195, 41, 20, 39, 27, 28, 19));
            FixedStats.Add(new StatModel(49, 2235, 41, 20, 40, 27, 28, 19));
            FixedStats.Add(new StatModel(50, 2275, 42, 21, 41, 28, 28, 19));
            FixedStats.Add(new StatModel(51, 2315, 42, 21, 41, 28, 28, 19));
            FixedStats.Add(new StatModel(52, 2355, 43, 21, 41, 28, 28, 19));
            FixedStats.Add(new StatModel(53, 2395, 44, 22, 42, 29, 28, 19));
            FixedStats.Add(new StatModel(54, 2435, 45, 22, 42, 29, 28, 19));
            FixedStats.Add(new StatModel(55, 2475, 45, 22, 43, 29, 29, 19));
            FixedStats.Add(new StatModel(56, 2515, 46, 23, 44, 30, 29, 20));
            FixedStats.Add(new StatModel(57, 2554, 46, 23, 44, 30, 29, 20));
            FixedStats.Add(new StatModel(58, 2594, 47, 23, 45, 30, 29, 20));
            FixedStats.Add(new StatModel(59, 2633, 48, 23, 45, 30, 29, 20));
            FixedStats.Add(new StatModel(60, 2672, 48, 24, 46, 31, 30, 20));
            FixedStats.Add(new StatModel(61, 2712, 49, 24, 46, 31, 30, 20));
            FixedStats.Add(new StatModel(62, 2751, 49, 24, 47, 32, 30, 20));
            FixedStats.Add(new StatModel(63, 2790, 50, 24, 47, 32, 30, 20));
            FixedStats.Add(new StatModel(64, 2829, 51, 25, 48, 32, 30, 20));
            FixedStats.Add(new StatModel(65, 2868, 51, 25, 48, 32, 31, 20));
            FixedStats.Add(new StatModel(66, 2907, 52, 25, 49, 33, 31, 20));
            FixedStats.Add(new StatModel(67, 2945, 52, 25, 49, 33, 31, 20));
            FixedStats.Add(new StatModel(68, 2984, 53, 26, 50, 33, 31, 20));
            FixedStats.Add(new StatModel(69, 3023, 53, 26, 50, 33, 31, 20));
            FixedStats.Add(new StatModel(70, 3061, 54, 26, 51, 34, 32, 20));
            FixedStats.Add(new StatModel(71, 3100, 54, 26, 51, 34, 32, 20));
            FixedStats.Add(new StatModel(72, 3138, 55, 26, 51, 34, 32, 21));
            FixedStats.Add(new StatModel(73, 3177, 56, 27, 52, 34, 32, 21));
            FixedStats.Add(new StatModel(74, 3215, 56, 27, 52, 35, 32, 21));
            FixedStats.Add(new StatModel(75, 3253, 57, 27, 53, 35, 32, 21));
            FixedStats.Add(new StatModel(76, 3291, 57, 27, 53, 35, 32, 21));
            FixedStats.Add(new StatModel(77, 3329, 57, 27, 54, 35, 32, 21));
            FixedStats.Add(new StatModel(78, 3367, 58, 28, 54, 35, 32, 21));
            FixedStats.Add(new StatModel(79, 3405, 59, 28, 55, 36, 32, 21));
            FixedStats.Add(new StatModel(80, 3443, 59, 28, 55, 36, 33, 21));
            FixedStats.Add(new StatModel(81, 3480, 59, 28, 55, 36, 33, 21));
            FixedStats.Add(new StatModel(82, 3518, 60, 28, 56, 36, 33, 21));
            FixedStats.Add(new StatModel(83, 3555, 60, 28, 56, 36, 33, 21));
            FixedStats.Add(new StatModel(84, 3593, 61, 29, 57, 37, 33, 21));
            FixedStats.Add(new StatModel(85, 3630, 62, 29, 57, 37, 34, 21));
            FixedStats.Add(new StatModel(86, 3667, 62, 29, 58, 37, 34, 21));
            FixedStats.Add(new StatModel(87, 3705, 62, 29, 58, 37, 34, 21));
            FixedStats.Add(new StatModel(88, 3742, 63, 29, 58, 37, 34, 22));
            FixedStats.Add(new StatModel(89, 3779, 63, 29, 59, 37, 34, 22));
            FixedStats.Add(new StatModel(90, 3816, 64, 30, 59, 38, 35, 22));
            FixedStats.Add(new StatModel(91, 3853, 64, 30, 59, 38, 35, 22));
            FixedStats.Add(new StatModel(92, 3890, 64, 30, 60, 38, 35, 22));
            FixedStats.Add(new StatModel(93, 3926, 65, 30, 60, 38, 35, 22));
            FixedStats.Add(new StatModel(94, 3963, 65, 30, 60, 38, 35, 22));
            FixedStats.Add(new StatModel(95, 4000, 66, 30, 61, 38, 36, 22));
            FixedStats.Add(new StatModel(96, 4036, 66, 30, 61, 38, 36, 22));
            FixedStats.Add(new StatModel(97, 4073, 66, 30, 62, 38, 36, 22));
            FixedStats.Add(new StatModel(98, 4109, 67, 30, 62, 38, 36, 22));
            FixedStats.Add(new StatModel(99, 4145, 67, 31, 62, 38, 36, 22));
            FixedStats.Add(new StatModel(100, 4181, 67, 31, 63, 39, 36, 22));
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
