using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public abstract class BaseDamageModel : BaseModel
    {
        public int TargetHP { get; set; }
        public int BaseDamage { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int MinNumberOfHits { get; set; }
        public int MaxNumberOfHits { get; set; }
        public decimal OneShotChance { get; set; }
        public int MinDamageDealt { get; set; }
        public int MaxDamageDealt { get; set; }
        public int MaxDamageWithMinNoOfHits { get; set; }

        public List<MultiplierModel> Multipliers { get; } = new List<MultiplierModel>();

        /// <summary>
        /// Average dmg per hit to kill with min # of hits
        /// </summary>
        public int AverageDmgPerHitToKillWithMinNoOfHits { get; set; }

        /// <summary>
        /// Approx. chance of killing target with min # of hits
        /// </summary>
        public decimal ChanceOfKillingWithMinNoOfHits { get; set; }

        /// <summary>
        /// Requires BaseDamage/TargetHP to be set
        /// </summary>
        protected void CalculateBase()
        {
            MinimumDamage = RoundDown(BaseDamage * (0 + 240) / 256);
            MinimumDamage = ApplyMultipliers(MinimumDamage);

            MaximumDamage = RoundDown(BaseDamage * (32 + 240) / 256));
            MaximumDamage = ApplyMultipliers(MaximumDamage);

            ChanceOfKillingWithMinNoOfHits = 0;
            for (int i = 0; i < 32; i++)
            {
                int dmgRoll = Math.Min(RoundDown(BaseDamage * (i + 240) / 256), 9999);
                if (dmgRoll > TargetHP)
                {
                    ChanceOfKillingWithMinNoOfHits = decimal.Round(i / 32 * 100, 2, MidpointRounding.AwayFromZero);
                    break;
                }
            }

            MinNumberOfHits = RoundUp(TargetHP / MaximumDamage);
            MaxNumberOfHits = RoundUp(TargetHP / MinimumDamage);

            MinDamageDealt = RoundUp(MinNumberOfHits * MaximumDamage);
            MaxDamageDealt = RoundUp(MaxNumberOfHits * MinimumDamage);

            MaxDamageWithMinNoOfHits = MaximumDamage * MinNumberOfHits;
            AverageDmgPerHitToKillWithMinNoOfHits = RoundUp(TargetHP / MinNumberOfHits);

            ChanceOfKillingWithMinNoOfHits = Math.Min(MinNumberOfHits * BaseDamage / TargetHP * 100, 1) * 100;
        }

        protected int ApplyMultipliers(int value)
        {
            foreach (MultiplierModel multiplier in Multipliers.Where(t => t.IsTicked))
            {
                value = RoundDown(value * multiplier.Multiplier);
            }

            return Math.Min(value, 9999);
        }
    }
}
