using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Ward : EnemyModel
    {
        public Ward() : base(190, "Ward", new Element[] { }, new Element[] { })
        {
            PopulateStats();
        }

        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 210, 2, 3, 2, 1, 15, 10));
            FixedStats.Add(new StatModel(2, 260, 3, 3, 2, 1, 15, 10));
            FixedStats.Add(new StatModel(3, 310, 4, 4, 3, 2, 15, 10));
            FixedStats.Add(new StatModel(4, 360, 5, 5, 4, 2, 15, 10));
            FixedStats.Add(new StatModel(5, 410, 6, 5, 4, 3, 15, 10));
            FixedStats.Add(new StatModel(6, 459, 7, 6, 5, 4, 16, 10));
            FixedStats.Add(new StatModel(7, 509, 8, 7, 6, 4, 16, 10));
            FixedStats.Add(new StatModel(8, 558, 8, 7, 6, 5, 16, 10));
            FixedStats.Add(new StatModel(9, 607, 9, 8, 7, 5, 16, 10));
            FixedStats.Add(new StatModel(10, 657, 10, 9, 8, 6, 16, 10));
            FixedStats.Add(new StatModel(11, 706, 11, 9, 8, 7, 16, 10));
            FixedStats.Add(new StatModel(12, 755, 12, 10, 9, 7, 17, 11));
            FixedStats.Add(new StatModel(13, 804, 12, 10, 9, 7, 17, 11));
            FixedStats.Add(new StatModel(14, 853, 13, 11, 10, 8, 17, 11));
            FixedStats.Add(new StatModel(15, 902, 14, 12, 11, 9, 17, 11));
            FixedStats.Add(new StatModel(16, 950, 15, 12, 11, 9, 17, 11));
            FixedStats.Add(new StatModel(17, 999, 16, 13, 12, 10, 17, 11));
            FixedStats.Add(new StatModel(18, 1048, 16, 13, 12, 10, 18, 11));
            FixedStats.Add(new StatModel(19, 1096, 17, 14, 13, 10, 18, 11));
            FixedStats.Add(new StatModel(20, 1145, 18, 15, 13, 11, 18, 11));
            FixedStats.Add(new StatModel(21, 1193, 19, 15, 14, 12, 18, 11));
            FixedStats.Add(new StatModel(22, 1242, 19, 16, 14, 12, 18, 11));
            FixedStats.Add(new StatModel(23, 1290, 20, 16, 15, 12, 18, 11));
            FixedStats.Add(new StatModel(24, 1338, 21, 17, 15, 13, 18, 11));
            FixedStats.Add(new StatModel(25, 1386, 21, 17, 16, 14, 18, 11));
            FixedStats.Add(new StatModel(26, 1434, 22, 18, 17, 14, 18, 11));
            FixedStats.Add(new StatModel(27, 1482, 23, 18, 17, 14, 18, 11));
            FixedStats.Add(new StatModel(28, 1530, 23, 19, 17, 15, 18, 11));
            FixedStats.Add(new StatModel(29, 1578, 24, 19, 18, 15, 18, 11));
            FixedStats.Add(new StatModel(30, 1625, 25, 20, 19, 16, 19, 11));
            FixedStats.Add(new StatModel(31, 1673, 26, 20, 19, 16, 19, 11));
            FixedStats.Add(new StatModel(32, 1720, 26, 21, 19, 16, 19, 11));
            FixedStats.Add(new StatModel(33, 1768, 27, 21, 20, 17, 19, 11));
            FixedStats.Add(new StatModel(34, 1815, 27, 22, 20, 17, 19, 11));
            FixedStats.Add(new StatModel(35, 1862, 28, 23, 21, 18, 19, 11));
            FixedStats.Add(new StatModel(36, 1910, 29, 23, 21, 18, 20, 12));
            FixedStats.Add(new StatModel(37, 1957, 29, 23, 21, 18, 20, 12));
            FixedStats.Add(new StatModel(38, 2004, 30, 24, 22, 19, 20, 12));
            FixedStats.Add(new StatModel(39, 2051, 30, 24, 22, 19, 20, 12));
            FixedStats.Add(new StatModel(40, 2098, 31, 25, 23, 20, 20, 12));
            FixedStats.Add(new StatModel(41, 2145, 32, 25, 23, 20, 20, 12));
            FixedStats.Add(new StatModel(42, 2191, 32, 26, 24, 20, 21, 12));
            FixedStats.Add(new StatModel(43, 2238, 33, 26, 24, 20, 21, 12));
            FixedStats.Add(new StatModel(44, 2285, 34, 27, 24, 21, 21, 12));
            FixedStats.Add(new StatModel(45, 2331, 34, 27, 25, 21, 21, 12));
            FixedStats.Add(new StatModel(46, 2378, 35, 28, 25, 22, 21, 12));
            FixedStats.Add(new StatModel(47, 2424, 35, 28, 25, 22, 21, 12));
            FixedStats.Add(new StatModel(48, 2470, 36, 28, 26, 22, 21, 12));
            FixedStats.Add(new StatModel(49, 2516, 36, 29, 26, 22, 21, 12));
            FixedStats.Add(new StatModel(50, 2562, 37, 29, 27, 23, 21, 12));
            FixedStats.Add(new StatModel(51, 2608, 38, 30, 27, 23, 21, 12));
            FixedStats.Add(new StatModel(52, 2654, 38, 30, 27, 23, 21, 12));
            FixedStats.Add(new StatModel(53, 2700, 39, 30, 28, 23, 21, 12));
            FixedStats.Add(new StatModel(54, 2746, 39, 31, 28, 24, 22, 12));
            FixedStats.Add(new StatModel(55, 2792, 40, 31, 28, 24, 22, 12));
            FixedStats.Add(new StatModel(56, 2838, 40, 32, 29, 24, 22, 12));
            FixedStats.Add(new StatModel(57, 2883, 41, 32, 29, 25, 22, 12));
            FixedStats.Add(new StatModel(58, 2929, 41, 32, 29, 25, 22, 12));
            FixedStats.Add(new StatModel(59, 2974, 42, 33, 29, 25, 22, 12));
            FixedStats.Add(new StatModel(60, 3019, 42, 33, 30, 26, 23, 13));
            FixedStats.Add(new StatModel(61, 3065, 43, 34, 30, 26, 23, 13));
            FixedStats.Add(new StatModel(62, 3110, 43, 34, 30, 26, 23, 13));
            FixedStats.Add(new StatModel(63, 3155, 43, 34, 30, 26, 23, 13));
            FixedStats.Add(new StatModel(64, 3200, 44, 35, 31, 26, 23, 13));
            FixedStats.Add(new StatModel(65, 3245, 45, 35, 31, 27, 23, 13));
            FixedStats.Add(new StatModel(66, 3290, 45, 35, 31, 27, 24, 13));
            FixedStats.Add(new StatModel(67, 3334, 45, 36, 31, 27, 24, 13));
            FixedStats.Add(new StatModel(68, 3379, 46, 36, 32, 27, 24, 13));
            FixedStats.Add(new StatModel(69, 3424, 46, 36, 32, 27, 24, 13));
            FixedStats.Add(new StatModel(70, 3468, 47, 37, 32, 28, 24, 13));
            FixedStats.Add(new StatModel(71, 3513, 47, 37, 32, 28, 24, 13));
            FixedStats.Add(new StatModel(72, 3557, 47, 37, 33, 28, 24, 13));
            FixedStats.Add(new StatModel(73, 3602, 48, 37, 33, 28, 24, 13));
            FixedStats.Add(new StatModel(74, 3646, 48, 38, 33, 28, 24, 13));
            FixedStats.Add(new StatModel(75, 3690, 49, 38, 33, 28, 24, 13));
            FixedStats.Add(new StatModel(76, 3734, 49, 38, 33, 28, 24, 13));
            FixedStats.Add(new StatModel(77, 3778, 49, 39, 33, 28, 24, 13));
            FixedStats.Add(new StatModel(78, 3822, 50, 39, 34, 28, 25, 13));
            FixedStats.Add(new StatModel(79, 3866, 50, 39, 34, 28, 25, 13));
            FixedStats.Add(new StatModel(80, 3910, 51, 40, 34, 29, 25, 13));
            FixedStats.Add(new StatModel(81, 3953, 51, 40, 34, 29, 25, 13));
            FixedStats.Add(new StatModel(82, 3997, 51, 40, 34, 29, 25, 13));
            FixedStats.Add(new StatModel(83, 4040, 51, 40, 34, 29, 25, 13));
            FixedStats.Add(new StatModel(84, 4084, 52, 40, 35, 29, 26, 14));
            FixedStats.Add(new StatModel(85, 4127, 52, 41, 35, 29, 26, 14));
            FixedStats.Add(new StatModel(86, 4170, 52, 41, 35, 29, 26, 14));
            FixedStats.Add(new StatModel(87, 4214, 53, 41, 35, 29, 26, 14));
            FixedStats.Add(new StatModel(88, 4257, 53, 41, 35, 29, 26, 14));
            FixedStats.Add(new StatModel(89, 4300, 53, 41, 35, 29, 26, 14));
            FixedStats.Add(new StatModel(90, 4343, 54, 42, 35, 30, 27, 14));
            FixedStats.Add(new StatModel(91, 4386, 54, 42, 35, 30, 27, 14));
            FixedStats.Add(new StatModel(92, 4429, 54, 42, 35, 30, 27, 14));
            FixedStats.Add(new StatModel(93, 4471, 54, 42, 35, 30, 27, 14));
            FixedStats.Add(new StatModel(94, 4514, 55, 42, 35, 30, 27, 14));
            FixedStats.Add(new StatModel(95, 4557, 55, 43, 36, 30, 27, 14));
            FixedStats.Add(new StatModel(96, 4599, 55, 43, 36, 30, 27, 14));
            FixedStats.Add(new StatModel(97, 4642, 56, 43, 36, 30, 27, 14));
            FixedStats.Add(new StatModel(98, 4684, 56, 43, 36, 30, 27, 14));
            FixedStats.Add(new StatModel(99, 4726, 56, 43, 36, 30, 27, 14));
            FixedStats.Add(new StatModel(100, 4768, 56, 44, 36, 30, 27, 14));
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
