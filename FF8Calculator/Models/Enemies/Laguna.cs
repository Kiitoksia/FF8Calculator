using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Laguna : EnemyModel
    {
        public Laguna() : base(188, "Laguna", new Element[] { }, new Element[] { })
        {
            PopulateStats();
        }

        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 184, 2, 1, 2, 1, 22, 14));
            FixedStats.Add(new StatModel(2, 228, 2, 2, 2, 2, 22, 14));
            FixedStats.Add(new StatModel(3, 272, 3, 3, 3, 3, 22, 14));
            FixedStats.Add(new StatModel(4, 316, 4, 3, 4, 3, 22, 14));
            FixedStats.Add(new StatModel(5, 360, 5, 4, 5, 4, 23, 14));
            FixedStats.Add(new StatModel(6, 403, 6, 5, 5, 5, 23, 14));
            FixedStats.Add(new StatModel(7, 447, 6, 6, 6, 5, 23, 15));
            FixedStats.Add(new StatModel(8, 490, 7, 6, 7, 6, 23, 15));
            FixedStats.Add(new StatModel(9, 533, 8, 7, 8, 6, 23, 15));
            FixedStats.Add(new StatModel(10, 577, 9, 8, 8, 7, 24, 15));
            FixedStats.Add(new StatModel(11, 620, 9, 8, 9, 8, 24, 15));
            FixedStats.Add(new StatModel(12, 663, 10, 9, 10, 8, 24, 15));
            FixedStats.Add(new StatModel(13, 706, 11, 9, 10, 9, 24, 15));
            FixedStats.Add(new StatModel(14, 749, 11, 10, 11, 9, 24, 15));
            FixedStats.Add(new StatModel(15, 792, 12, 11, 12, 10, 25, 15));
            FixedStats.Add(new StatModel(16, 834, 13, 11, 12, 10, 25, 15));
            FixedStats.Add(new StatModel(17, 877, 14, 12, 13, 11, 25, 15));
            FixedStats.Add(new StatModel(18, 920, 14, 12, 14, 12, 25, 15));
            FixedStats.Add(new StatModel(19, 962, 15, 13, 14, 12, 25, 15));
            FixedStats.Add(new StatModel(20, 1005, 16, 14, 15, 13, 25, 15));
            FixedStats.Add(new StatModel(21, 1047, 16, 14, 15, 13, 25, 16));
            FixedStats.Add(new StatModel(22, 1090, 17, 15, 16, 14, 25, 16));
            FixedStats.Add(new StatModel(23, 1132, 18, 15, 17, 14, 25, 16));
            FixedStats.Add(new StatModel(24, 1174, 18, 16, 17, 14, 25, 16));
            FixedStats.Add(new StatModel(25, 1216, 19, 17, 18, 15, 26, 16));
            FixedStats.Add(new StatModel(26, 1258, 20, 17, 18, 16, 26, 16));
            FixedStats.Add(new StatModel(27, 1300, 20, 18, 19, 16, 26, 16));
            FixedStats.Add(new StatModel(28, 1342, 21, 18, 20, 17, 26, 16));
            FixedStats.Add(new StatModel(29, 1384, 21, 18, 20, 17, 26, 16));
            FixedStats.Add(new StatModel(30, 1425, 22, 19, 21, 18, 27, 16));
            FixedStats.Add(new StatModel(31, 1467, 23, 20, 21, 18, 27, 16));
            FixedStats.Add(new StatModel(32, 1508, 23, 20, 22, 18, 27, 16));
            FixedStats.Add(new StatModel(33, 1550, 24, 20, 22, 19, 27, 16));
            FixedStats.Add(new StatModel(34, 1591, 24, 21, 23, 19, 27, 16));
            FixedStats.Add(new StatModel(35, 1632, 25, 22, 24, 20, 28, 17));
            FixedStats.Add(new StatModel(36, 1674, 25, 22, 24, 20, 28, 17));
            FixedStats.Add(new StatModel(37, 1715, 26, 23, 25, 21, 28, 17));
            FixedStats.Add(new StatModel(38, 1756, 26, 23, 25, 21, 28, 17));
            FixedStats.Add(new StatModel(39, 1797, 27, 23, 26, 21, 28, 17));
            FixedStats.Add(new StatModel(40, 1838, 28, 24, 26, 22, 28, 17));
            FixedStats.Add(new StatModel(41, 1879, 28, 24, 27, 22, 28, 17));
            FixedStats.Add(new StatModel(42, 1919, 29, 25, 27, 23, 28, 17));
            FixedStats.Add(new StatModel(43, 1960, 29, 25, 28, 23, 28, 17));
            FixedStats.Add(new StatModel(44, 2001, 30, 26, 28, 23, 28, 17));
            FixedStats.Add(new StatModel(45, 2041, 30, 26, 29, 24, 29, 17));
            FixedStats.Add(new StatModel(46, 2082, 31, 27, 29, 24, 29, 17));
            FixedStats.Add(new StatModel(47, 2122, 31, 27, 30, 25, 29, 17));
            FixedStats.Add(new StatModel(48, 2162, 32, 27, 30, 25, 29, 17));
            FixedStats.Add(new StatModel(49, 2202, 32, 28, 30, 25, 29, 18));
            FixedStats.Add(new StatModel(50, 2242, 33, 28, 31, 26, 30, 18));
            FixedStats.Add(new StatModel(51, 2282, 33, 29, 31, 26, 30, 18));
            FixedStats.Add(new StatModel(52, 2322, 34, 29, 32, 26, 30, 18));
            FixedStats.Add(new StatModel(53, 2362, 34, 29, 32, 27, 30, 18));
            FixedStats.Add(new StatModel(54, 2402, 34, 30, 33, 27, 30, 18));
            FixedStats.Add(new StatModel(55, 2442, 35, 30, 33, 28, 31, 18));
            FixedStats.Add(new StatModel(56, 2482, 35, 30, 33, 28, 31, 18));
            FixedStats.Add(new StatModel(57, 2521, 36, 31, 34, 28, 31, 18));
            FixedStats.Add(new StatModel(58, 2561, 36, 31, 34, 28, 31, 18));
            FixedStats.Add(new StatModel(59, 2600, 37, 31, 35, 28, 31, 18));
            FixedStats.Add(new StatModel(60, 2639, 37, 32, 35, 29, 31, 18));
            FixedStats.Add(new StatModel(61, 2679, 38, 32, 35, 29, 31, 18));
            FixedStats.Add(new StatModel(62, 2718, 38, 33, 36, 29, 31, 18));
            FixedStats.Add(new StatModel(63, 2757, 38, 33, 36, 30, 31, 19));
            FixedStats.Add(new StatModel(64, 2796, 39, 33, 37, 30, 31, 19));
            FixedStats.Add(new StatModel(65, 2835, 39, 34, 37, 30, 32, 19));
            FixedStats.Add(new StatModel(66, 2874, 39, 34, 37, 30, 32, 19));
            FixedStats.Add(new StatModel(67, 2912, 40, 34, 38, 31, 32, 19));
            FixedStats.Add(new StatModel(68, 2951, 40, 34, 38, 31, 32, 19));
            FixedStats.Add(new StatModel(69, 2990, 40, 34, 38, 31, 32, 19));
            FixedStats.Add(new StatModel(70, 3028, 41, 35, 39, 32, 33, 19));
            FixedStats.Add(new StatModel(71, 3067, 41, 35, 39, 32, 33, 19));
            FixedStats.Add(new StatModel(72, 3105, 41, 35, 39, 32, 33, 19));
            FixedStats.Add(new StatModel(73, 3144, 42, 36, 40, 32, 33, 19));
            FixedStats.Add(new StatModel(74, 3182, 42, 36, 40, 32, 33, 19));
            FixedStats.Add(new StatModel(75, 3220, 42, 36, 40, 33, 34, 19));
            FixedStats.Add(new StatModel(76, 3258, 43, 36, 40, 33, 34, 19));
            FixedStats.Add(new StatModel(77, 3296, 43, 37, 41, 33, 34, 20));
            FixedStats.Add(new StatModel(78, 3334, 43, 37, 41, 33, 34, 20));
            FixedStats.Add(new StatModel(79, 3372, 43, 37, 41, 33, 34, 20));
            FixedStats.Add(new StatModel(80, 3410, 44, 37, 42, 33, 34, 20));
            FixedStats.Add(new StatModel(81, 3447, 44, 37, 42, 33, 34, 20));
            FixedStats.Add(new StatModel(82, 3485, 44, 38, 42, 33, 34, 20));
            FixedStats.Add(new StatModel(83, 3522, 45, 38, 42, 34, 34, 20));
            FixedStats.Add(new StatModel(84, 3560, 45, 38, 42, 34, 34, 20));
            FixedStats.Add(new StatModel(85, 3597, 45, 38, 43, 34, 35, 20));
            FixedStats.Add(new StatModel(86, 3634, 45, 38, 43, 34, 35, 20));
            FixedStats.Add(new StatModel(87, 3672, 46, 39, 43, 34, 35, 20));
            FixedStats.Add(new StatModel(88, 3709, 46, 39, 43, 34, 35, 20));
            FixedStats.Add(new StatModel(89, 3746, 46, 39, 44, 34, 35, 20));
            FixedStats.Add(new StatModel(90, 3783, 46, 39, 44, 35, 36, 20));
            FixedStats.Add(new StatModel(91, 3820, 47, 39, 44, 35, 36, 21));
            FixedStats.Add(new StatModel(92, 3857, 47, 39, 44, 35, 36, 21));
            FixedStats.Add(new StatModel(93, 3893, 47, 39, 44, 35, 36, 21));
            FixedStats.Add(new StatModel(94, 3930, 47, 40, 45, 35, 36, 21));
            FixedStats.Add(new StatModel(95, 3967, 47, 40, 45, 35, 37, 21));
            FixedStats.Add(new StatModel(96, 4003, 47, 40, 45, 35, 37, 21));
            FixedStats.Add(new StatModel(97, 4040, 48, 40, 45, 35, 37, 21));
            FixedStats.Add(new StatModel(98, 4076, 48, 40, 45, 35, 37, 21));
            FixedStats.Add(new StatModel(99, 4112, 48, 40, 45, 35, 37, 21));
            FixedStats.Add(new StatModel(100, 4148, 48, 41, 46, 36, 37, 21));
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
