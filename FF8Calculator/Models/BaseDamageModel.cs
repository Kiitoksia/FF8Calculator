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
            int[] damageRolls = Enumerable.Range(0, 32).Select(t => ApplyMultipliers(RoundDown(BaseDamage * (t + 240) / 256))).ToArray();


            MinimumDamage = damageRolls[0];
            MaximumDamage = damageRolls[31];

            OneShotChance = 0;
            for (int i = 0; i < 32; i++)
            {
                int dmgRoll = damageRolls[i];
                if (dmgRoll > TargetHP)
                {
                    OneShotChance = decimal.Round((32 - i) / 32 * 100, 2, MidpointRounding.AwayFromZero);
                    break;
                }
            }

            MinNumberOfHits = RoundUp(TargetHP / MaximumDamage);
            MaxNumberOfHits = RoundUp(TargetHP / MinimumDamage);

            MinDamageDealt = RoundUp(MinNumberOfHits * MaximumDamage);
            MaxDamageDealt = RoundUp(MaxNumberOfHits * MinimumDamage);

            MaxDamageWithMinNoOfHits = MaximumDamage * MinNumberOfHits;
            AverageDmgPerHitToKillWithMinNoOfHits = RoundUp(TargetHP / MinNumberOfHits);


            //CalculateChangeOfKillingWithMinNoofHits(damageRolls);
            //ChanceOfKillingWithMinNoOfHits = Math.Min(MinNumberOfHits * BaseDamage / TargetHP * 100, 1) * 100;
        }

        private void CalculateChangeOfKillingWithMinNoofHits(int[] damageRolls)
        {

            int total = (int)Math.Pow(33, MinNumberOfHits);
           

            if (MaxNumberOfHits == 1)
            {
                ChanceOfKillingWithMinNoOfHits = 100; // Lowest damage roll always kills in one hit                
            }
            else
            {
                // Min No of hits is assuming we always roll max damage
                // We need to check how many iterations actually kill
                // This is done by reversing the damage rolls so we work downwards, and then counting all possible damage rolls
                
                // Given [9999, 5000, 3000, 20000, 1000]

                // 
            }




            // Do we want to calculate in reverse (highest -> lowest)
            int killableCombos = RecursiveCheck(damageRolls.Reverse().ToArray(), TargetHP, MinNumberOfHits);

            decimal percent = killableCombos / total;
            ChanceOfKillingWithMinNoOfHits = percent * 100;
        }

        private int RecursiveCheck(int[] damageRolls, int remainingHP, int hitsLeft)
        {
            if (hitsLeft == 0) return 0;
            if (remainingHP <= 0) return 0;

            // We start at max damage rolls and work our way down


            int killableCombos = 0;            


            for (int i = 0; i <= 32; i++)
            {
                int damage = damageRolls[i];

                if (damage >= remainingHP)
                {
                    // This damage roll kills
                    killableCombos++;
                }
                else
                {
                    // Damage roll does not kill outright, lower HP/hits and run again
                    remainingHP -= damage;
                    hitsLeft--;
                    int additionalCombosRequired = RecursiveCheck(damageRolls, remainingHP, hitsLeft);
                    if (additionalCombosRequired == 0)
                    {
                        // Either no hits left, or no remaining HP, stop calculating
                        return killableCombos;
                    }

                    killableCombos += additionalCombosRequired;
                }
            }

            return killableCombos;
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
