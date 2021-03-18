using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class Kiros : EnemyModel
    {
        public Kiros() : base(189, "Kiros", new Element[] { }, new Element[] { })
        {
            PopulateStats();
            
        }


        #region Stats
        private void PopulateStats()
        {
            FixedStats.Add(new StatModel(1, 160, 1, 1, 2, 2, 30, 15));
            FixedStats.Add(new StatModel(2, 200, 2, 2, 3, 2, 30, 15));
            FixedStats.Add(new StatModel(3, 240, 3, 2, 4, 3, 30, 15));
            FixedStats.Add(new StatModel(4, 280, 3, 3, 4, 4, 30, 15));
            FixedStats.Add(new StatModel(5, 320, 4, 4, 5, 5, 31, 15));
            FixedStats.Add(new StatModel(6, 359, 5, 4, 6, 5, 31, 16));
            FixedStats.Add(new StatModel(7, 399, 6, 5, 7, 6, 31, 16));
            FixedStats.Add(new StatModel(8, 438, 6, 5, 8, 6, 31, 16));
            FixedStats.Add(new StatModel(9, 477, 7, 6, 8, 7, 31, 16));
            FixedStats.Add(new StatModel(10, 517, 8, 7, 9, 8, 32, 16));
            FixedStats.Add(new StatModel(11, 556, 8, 7, 10, 8, 32, 16));
            FixedStats.Add(new StatModel(12, 595, 9, 8, 11, 9, 32, 16));
            FixedStats.Add(new StatModel(13, 634, 10, 8, 11, 9, 32, 16));
            FixedStats.Add(new StatModel(14, 673, 10, 8, 12, 10, 32, 16));
            FixedStats.Add(new StatModel(15, 712, 11, 9, 13, 11, 33, 16));
            FixedStats.Add(new StatModel(16, 750, 12, 10, 13, 11, 33, 16));
            FixedStats.Add(new StatModel(17, 789, 12, 10, 14, 12, 33, 16));
            FixedStats.Add(new StatModel(18, 828, 13, 11, 15, 13, 33, 17));
            FixedStats.Add(new StatModel(19, 866, 14, 11, 15, 13, 33, 17));
            FixedStats.Add(new StatModel(20, 905, 14, 12, 16, 14, 34, 17));
            FixedStats.Add(new StatModel(21, 943, 15, 12, 17, 14, 34, 17));
            FixedStats.Add(new StatModel(22, 982, 15, 13, 17, 15, 34, 17));
            FixedStats.Add(new StatModel(23, 1020, 16, 13, 18, 15, 34, 17));
            FixedStats.Add(new StatModel(24, 1058, 17, 13, 19, 16, 34, 17));
            FixedStats.Add(new StatModel(25, 1096, 17, 14, 20, 17, 35, 17));
            FixedStats.Add(new StatModel(26, 1134, 18, 14, 20, 17, 35, 17));
            FixedStats.Add(new StatModel(27, 1172, 18, 15, 21, 18, 35, 17));
            FixedStats.Add(new StatModel(28, 1210, 19, 15, 21, 18, 35, 17));
            FixedStats.Add(new StatModel(29, 1248, 19, 15, 22, 19, 35, 17));
            FixedStats.Add(new StatModel(30, 1285, 20, 16, 23, 20, 36, 18));
            FixedStats.Add(new StatModel(31, 1323, 21, 17, 23, 20, 36, 18));
            FixedStats.Add(new StatModel(32, 1360, 21, 17, 24, 20, 36, 18));
            FixedStats.Add(new StatModel(33, 1398, 22, 17, 24, 21, 36, 18));
            FixedStats.Add(new StatModel(34, 1435, 22, 18, 25, 21, 36, 18));
            FixedStats.Add(new StatModel(35, 1472, 23, 18, 26, 22, 36, 18));
            FixedStats.Add(new StatModel(36, 1510, 23, 19, 26, 22, 36, 18));
            FixedStats.Add(new StatModel(37, 1547, 24, 19, 27, 23, 36, 18));
            FixedStats.Add(new StatModel(38, 1584, 24, 19, 27, 23, 36, 18));
            FixedStats.Add(new StatModel(39, 1621, 25, 19, 28, 24, 36, 18));
            FixedStats.Add(new StatModel(40, 1658, 25, 20, 28, 24, 37, 18));
            FixedStats.Add(new StatModel(41, 1695, 26, 20, 29, 25, 37, 18));
            FixedStats.Add(new StatModel(42, 1731, 26, 21, 29, 25, 37, 19));
            FixedStats.Add(new StatModel(43, 1768, 27, 21, 30, 25, 37, 19));
            FixedStats.Add(new StatModel(44, 1805, 27, 21, 30, 26, 37, 19));
            FixedStats.Add(new StatModel(45, 1841, 28, 22, 31, 27, 38, 19));
            FixedStats.Add(new StatModel(46, 1878, 28, 22, 32, 27, 38, 19));
            FixedStats.Add(new StatModel(47, 1914, 28, 22, 32, 27, 38, 19));
            FixedStats.Add(new StatModel(48, 1950, 29, 23, 33, 27, 38, 19));
            FixedStats.Add(new StatModel(49, 1986, 29, 23, 33, 28, 38, 19));
            FixedStats.Add(new StatModel(50, 2022, 30, 24, 34, 29, 39, 19));
            FixedStats.Add(new StatModel(51, 2058, 30, 24, 34, 29, 39, 19));
            FixedStats.Add(new StatModel(52, 2094, 31, 24, 35, 29, 39, 19));
            FixedStats.Add(new StatModel(53, 2130, 31, 24, 35, 29, 39, 19));
            FixedStats.Add(new StatModel(54, 2166, 31, 24, 35, 30, 39, 20));
            FixedStats.Add(new StatModel(55, 2202, 32, 25, 36, 31, 40, 20));
            FixedStats.Add(new StatModel(56, 2238, 32, 25, 36, 31, 40, 20));
            FixedStats.Add(new StatModel(57, 2273, 33, 25, 37, 31, 40, 20));
            FixedStats.Add(new StatModel(58, 2309, 33, 25, 37, 31, 40, 20));
            FixedStats.Add(new StatModel(59, 2344, 33, 26, 38, 32, 40, 20));
            FixedStats.Add(new StatModel(60, 2379, 34, 26, 38, 32, 41, 20));
            FixedStats.Add(new StatModel(61, 2415, 34, 26, 39, 32, 41, 20));
            FixedStats.Add(new StatModel(62, 2450, 34, 27, 39, 33, 41, 20));
            FixedStats.Add(new StatModel(63, 2485, 35, 27, 39, 33, 41, 20));
            FixedStats.Add(new StatModel(64, 2520, 35, 27, 40, 33, 41, 20));
            FixedStats.Add(new StatModel(65, 2555, 36, 27, 40, 34, 42, 20));
            FixedStats.Add(new StatModel(66, 2590, 36, 28, 41, 34, 42, 21));
            FixedStats.Add(new StatModel(67, 2624, 36, 28, 41, 34, 42, 21));
            FixedStats.Add(new StatModel(68, 2659, 36, 28, 41, 34, 42, 21));
            FixedStats.Add(new StatModel(69, 2694, 37, 28, 42, 35, 42, 21));
            FixedStats.Add(new StatModel(70, 2728, 37, 28, 42, 35, 42, 21));
            FixedStats.Add(new StatModel(71, 2763, 37, 28, 42, 35, 42, 21));
            FixedStats.Add(new StatModel(72, 2797, 37, 29, 43, 36, 42, 21));
            FixedStats.Add(new StatModel(73, 2832, 38, 29, 43, 36, 42, 21));
            FixedStats.Add(new StatModel(74, 2866, 38, 29, 43, 36, 42, 21));
            FixedStats.Add(new StatModel(75, 2900, 38, 29, 44, 37, 43, 21));
            FixedStats.Add(new StatModel(76, 2934, 38, 29, 44, 37, 43, 21));
            FixedStats.Add(new StatModel(77, 2968, 39, 29, 44, 37, 43, 21));
            FixedStats.Add(new StatModel(78, 3002, 39, 29, 45, 37, 43, 22));
            FixedStats.Add(new StatModel(79, 3036, 39, 29, 45, 37, 43, 22));
            FixedStats.Add(new StatModel(80, 3070, 40, 30, 45, 38, 44, 22));
            FixedStats.Add(new StatModel(81, 3103, 40, 30, 46, 38, 44, 22));
            FixedStats.Add(new StatModel(82, 3137, 40, 30, 46, 38, 44, 22));
            FixedStats.Add(new StatModel(83, 3170, 40, 30, 46, 38, 44, 22));
            FixedStats.Add(new StatModel(84, 3204, 40, 30, 46, 38, 44, 22));
            FixedStats.Add(new StatModel(85, 3237, 41, 30, 47, 39, 45, 22));
            FixedStats.Add(new StatModel(86, 3270, 41, 30, 47, 39, 45, 22));
            FixedStats.Add(new StatModel(87, 3304, 41, 30, 47, 39, 45, 22));
            FixedStats.Add(new StatModel(88, 3337, 41, 30, 48, 39, 45, 22));
            FixedStats.Add(new StatModel(89, 3370, 41, 30, 48, 39, 45, 22));
            FixedStats.Add(new StatModel(90, 3403, 42, 31, 48, 40, 46, 23));
            FixedStats.Add(new StatModel(91, 3436, 42, 31, 48, 40, 46, 23));
            FixedStats.Add(new StatModel(92, 3469, 42, 31, 49, 40, 46, 23));
            FixedStats.Add(new StatModel(93, 3501, 42, 31, 49, 40, 46, 23));
            FixedStats.Add(new StatModel(94, 3534, 42, 31, 49, 40, 46, 23));
            FixedStats.Add(new StatModel(95, 3567, 42, 31, 49, 40, 47, 23));
            FixedStats.Add(new StatModel(96, 3599, 42, 31, 49, 40, 47, 23));
            FixedStats.Add(new StatModel(97, 3632, 42, 31, 50, 40, 47, 23));
            FixedStats.Add(new StatModel(98, 3664, 42, 31, 50, 40, 47, 23));
            FixedStats.Add(new StatModel(99, 3696, 43, 31, 50, 40, 47, 23));
            FixedStats.Add(new StatModel(100, 3728, 43, 31, 50, 41, 48, 23));
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
