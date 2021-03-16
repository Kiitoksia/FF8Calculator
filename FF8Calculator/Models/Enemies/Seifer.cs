using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Seifer : EnemyModel
    {
        public Seifer() : base(187, "Seifer (Player)", new Element[] { }, new Element[] { })
        {

        }

        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 275, 3, 2, 2, 5, 15, 12));
            FixedStats.Add(new StatModel(2, 335, 4, 3, 3, 5, 15, 12));
            FixedStats.Add(new StatModel(3, 395, 4, 3, 4, 6, 16, 12));
            FixedStats.Add(new StatModel(4, 455, 5, 4, 4, 7, 16, 12));
            FixedStats.Add(new StatModel(5, 515, 6, 5, 5, 7, 16, 12));
            FixedStats.Add(new StatModel(6, 574, 7, 6, 6, 8, 17, 12));
            FixedStats.Add(new StatModel(7, 634, 8, 6, 7, 8, 17, 13));
            FixedStats.Add(new StatModel(8, 693, 8, 7, 7, 9, 17, 13));
            FixedStats.Add(new StatModel(9, 752, 9, 7, 8, 10, 18, 13));
            FixedStats.Add(new StatModel(10, 812, 10, 8, 9, 10, 18, 13));
            FixedStats.Add(new StatModel(11, 871, 11, 9, 9, 11, 18, 13));
            FixedStats.Add(new StatModel(12, 930, 11, 9, 10, 11, 19, 13));
            FixedStats.Add(new StatModel(13, 989, 12, 10, 10, 12, 19, 13));
            FixedStats.Add(new StatModel(14, 1048, 13, 10, 11, 12, 19, 13));
            FixedStats.Add(new StatModel(15, 1107, 13, 11, 12, 13, 20, 13));
            FixedStats.Add(new StatModel(16, 1165, 14, 12, 12, 14, 20, 13));
            FixedStats.Add(new StatModel(17, 1224, 15, 12, 13, 14, 20, 13));
            FixedStats.Add(new StatModel(18, 1283, 15, 13, 13, 15, 21, 13));
            FixedStats.Add(new StatModel(19, 1341, 16, 13, 14, 15, 21, 13));
            FixedStats.Add(new StatModel(20, 1400, 17, 14, 15, 16, 21, 13));
            FixedStats.Add(new StatModel(21, 1458, 17, 14, 15, 16, 22, 14));
            FixedStats.Add(new StatModel(22, 1517, 18, 15, 16, 17, 22, 14));
            FixedStats.Add(new StatModel(23, 1575, 19, 15, 16, 17, 22, 14));
            FixedStats.Add(new StatModel(24, 1633, 19, 16, 17, 18, 23, 14));
            FixedStats.Add(new StatModel(25, 1691, 20, 17, 18, 18, 23, 14));
            FixedStats.Add(new StatModel(26, 1749, 21, 17, 18, 19, 23, 14));
            FixedStats.Add(new StatModel(27, 1807, 21, 18, 19, 19, 24, 14));
            FixedStats.Add(new StatModel(28, 1865, 22, 18, 19, 20, 24, 14));
            FixedStats.Add(new StatModel(29, 1923, 22, 18, 20, 20, 24, 14));
            FixedStats.Add(new StatModel(30, 1980, 23, 19, 21, 20, 24, 14));
            FixedStats.Add(new StatModel(31, 2038, 24, 20, 21, 21, 24, 14));
            FixedStats.Add(new StatModel(32, 2095, 24, 20, 21, 21, 24, 14));
            FixedStats.Add(new StatModel(33, 2153, 25, 21, 22, 22, 25, 14));
            FixedStats.Add(new StatModel(34, 2210, 25, 21, 22, 22, 25, 14));
            FixedStats.Add(new StatModel(35, 2267, 26, 22, 23, 23, 25, 15));
            FixedStats.Add(new StatModel(36, 2325, 26, 22, 23, 23, 26, 15));
            FixedStats.Add(new StatModel(37, 2382, 27, 22, 24, 23, 26, 15));
            FixedStats.Add(new StatModel(38, 2439, 27, 23, 24, 24, 26, 15));
            FixedStats.Add(new StatModel(39, 2496, 28, 23, 25, 24, 27, 15));
            FixedStats.Add(new StatModel(40, 2553, 29, 24, 26, 25, 27, 15));
            FixedStats.Add(new StatModel(41, 2610, 29, 24, 26, 25, 27, 15));
            FixedStats.Add(new StatModel(42, 2666, 30, 25, 26, 25, 28, 15));
            FixedStats.Add(new StatModel(43, 2723, 30, 25, 27, 26, 28, 15));
            FixedStats.Add(new StatModel(44, 2780, 31, 25, 27, 26, 28, 15));
            FixedStats.Add(new StatModel(45, 2836, 31, 26, 28, 26, 29, 15));
            FixedStats.Add(new StatModel(46, 2893, 32, 26, 28, 27, 29, 15));
            FixedStats.Add(new StatModel(47, 2949, 32, 27, 29, 27, 29, 15));
            FixedStats.Add(new StatModel(48, 3005, 32, 27, 29, 28, 30, 15));
            FixedStats.Add(new StatModel(49, 3061, 33, 27, 29, 28, 30, 16));
            FixedStats.Add(new StatModel(50, 3117, 34, 28, 30, 28, 30, 16));
            FixedStats.Add(new StatModel(51, 3173, 34, 28, 30, 29, 31, 16));
            FixedStats.Add(new StatModel(52, 3229, 34, 29, 31, 29, 31, 16));
            FixedStats.Add(new StatModel(53, 3285, 35, 29, 31, 29, 31, 16));
            FixedStats.Add(new StatModel(54, 3341, 35, 29, 32, 30, 32, 16));
            FixedStats.Add(new StatModel(55, 3397, 36, 30, 32, 30, 32, 16));
            FixedStats.Add(new StatModel(56, 3453, 36, 30, 32, 30, 32, 16));
            FixedStats.Add(new StatModel(57, 3508, 36, 30, 33, 31, 33, 16));
            FixedStats.Add(new StatModel(58, 3564, 37, 31, 33, 31, 33, 16));
            FixedStats.Add(new StatModel(59, 3619, 37, 31, 34, 31, 33, 16));
            FixedStats.Add(new StatModel(60, 3674, 38, 32, 34, 32, 33, 16));
            FixedStats.Add(new StatModel(61, 3730, 38, 32, 34, 32, 33, 16));
            FixedStats.Add(new StatModel(62, 3785, 38, 32, 35, 32, 33, 16));
            FixedStats.Add(new StatModel(63, 3840, 39, 32, 35, 32, 34, 17));
            FixedStats.Add(new StatModel(64, 3895, 39, 33, 35, 33, 34, 17));
            FixedStats.Add(new StatModel(65, 3950, 40, 33, 36, 33, 34, 17));
            FixedStats.Add(new StatModel(66, 4005, 40, 33, 36, 33, 35, 17));
            FixedStats.Add(new StatModel(67, 4059, 40, 33, 37, 33, 35, 17));
            FixedStats.Add(new StatModel(68, 4114, 40, 34, 37, 34, 35, 17));
            FixedStats.Add(new StatModel(69, 4169, 41, 34, 37, 34, 36, 17));
            FixedStats.Add(new StatModel(70, 4223, 41, 34, 38, 34, 36, 17));
            FixedStats.Add(new StatModel(71, 4278, 41, 34, 38, 34, 36, 17));
            FixedStats.Add(new StatModel(72, 4332, 42, 35, 38, 35, 37, 17));
            FixedStats.Add(new StatModel(73, 4387, 42, 35, 38, 35, 37, 17));
            FixedStats.Add(new StatModel(74, 4441, 42, 35, 39, 35, 37, 17));
            FixedStats.Add(new StatModel(75, 4495, 43, 36, 39, 35, 38, 17));
            FixedStats.Add(new StatModel(76, 4549, 43, 36, 39, 35, 38, 17));
            FixedStats.Add(new StatModel(77, 4603, 43, 36, 40, 35, 38, 18));
            FixedStats.Add(new StatModel(78, 4657, 43, 36, 40, 36, 39, 18));
            FixedStats.Add(new StatModel(79, 4711, 44, 36, 40, 36, 39, 18));
            FixedStats.Add(new StatModel(80, 4765, 44, 37, 41, 36, 39, 18));
            FixedStats.Add(new StatModel(81, 4818, 44, 37, 41, 36, 40, 18));
            FixedStats.Add(new StatModel(82, 4872, 44, 37, 41, 36, 40, 18));
            FixedStats.Add(new StatModel(83, 4925, 45, 37, 41, 36, 40, 18));
            FixedStats.Add(new StatModel(84, 4979, 45, 37, 41, 37, 41, 18));
            FixedStats.Add(new StatModel(85, 5032, 45, 37, 42, 37, 41, 18));
            FixedStats.Add(new StatModel(86, 5085, 45, 38, 42, 37, 41, 18));
            FixedStats.Add(new StatModel(87, 5139, 45, 38, 42, 37, 42, 18));
            FixedStats.Add(new StatModel(88, 5192, 46, 38, 42, 37, 42, 18));
            FixedStats.Add(new StatModel(89, 5245, 46, 38, 42, 37, 42, 18));
            FixedStats.Add(new StatModel(90, 5298, 46, 38, 43, 37, 42, 18));
            FixedStats.Add(new StatModel(91, 5351, 46, 38, 43, 37, 42, 19));
            FixedStats.Add(new StatModel(92, 5404, 46, 39, 43, 38, 42, 19));
            FixedStats.Add(new StatModel(93, 5456, 46, 39, 43, 38, 43, 19));
            FixedStats.Add(new StatModel(94, 5509, 47, 39, 43, 38, 43, 19));
            FixedStats.Add(new StatModel(95, 5562, 47, 39, 44, 38, 43, 19));
            FixedStats.Add(new StatModel(96, 5614, 47, 39, 44, 38, 44, 19));
            FixedStats.Add(new StatModel(97, 5667, 47, 39, 44, 38, 44, 19));
            FixedStats.Add(new StatModel(98, 5719, 47, 39, 44, 38, 44, 19));
            FixedStats.Add(new StatModel(99, 5771, 47, 39, 44, 38, 45, 19));
            FixedStats.Add(new StatModel(100, 5823, 48, 39, 45, 38, 45, 19));
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
