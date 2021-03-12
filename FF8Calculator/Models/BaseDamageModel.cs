using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public abstract class BaseDamageModel : BaseModel
    {
        private int _averageDmgPerHitToKillWithMinNoOfHits;
        private decimal _chanceOfKillingWithMinNoOfHits;
        private int _maxDamageDealt;
        private int _maxDamageWithMinNoOfHits;
        private int _maximumDamage;
        private int _maxNumberOfHits;
        private int _minDamageDealt;
        private int _minimumDamage;
        private int _minNumberOfHits;
        private decimal _oneShotChance;

        public BaseDamageModel()
        {
            Multipliers.CollectionChanged += (s, e) => OnPropertyChanged(nameof(Multipliers));
            PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(Multipliers))
                {
                    CalculateBase();
                }
            };
        }

        private void CalculateChangeOfKillingWithMinNoofHits(int[] damageRolls)
        {

            // TODO
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

        /// <summary>
        /// Requires BaseDamage/TargetHP to be set
        /// </summary>
        protected void CalculateBase()
        {
            // Reset all values to zero first
            MinimumDamage = 0;
            MaximumDamage = 0;
            OneShotChance = 0;
            MinNumberOfHits = 0;
            MaxDamageDealt = 0;
            MinDamageDealt = 0;
            MaxDamageWithMinNoOfHits = 0;
            AverageDmgPerHitToKillWithMinNoOfHits = 0;

            if (BaseDamage == 0 || TargetHP == 0) return;

            int[] damageRolls = Enumerable.Range(0, 32).Select(t => ApplyMultipliers(RoundDown(BaseDamage * (t + 240) / 256))).ToArray();

            damageRolls = damageRolls.Where(t => t > 0).ToArray();
            if (damageRolls.Length == 0) return;

            MinimumDamage = damageRolls.First();
            MaximumDamage = damageRolls.Last();

            for (int i = 0; i < 32; i++)
            {
                int dmgRoll = damageRolls[i % damageRolls.Length];
                if (dmgRoll > TargetHP)
                {
                    OneShotChance = decimal.Round((32 - i) / 32 * 100, 2, MidpointRounding.AwayFromZero);
                    break;
                }
            }

            MinNumberOfHits = RoundUp(TargetHP / MaximumDamage);
            MaxNumberOfHits = RoundUp(TargetHP / MinimumDamage);

            MinDamageDealt = MinNumberOfHits * MaximumDamage;
            MaxDamageDealt = MaxNumberOfHits * MinimumDamage;

            MaxDamageWithMinNoOfHits = MaximumDamage * MinNumberOfHits;
            AverageDmgPerHitToKillWithMinNoOfHits = RoundUp(TargetHP / MinNumberOfHits);


            //CalculateChangeOfKillingWithMinNoofHits(damageRolls);
            //ChanceOfKillingWithMinNoOfHits = Math.Min(MinNumberOfHits * BaseDamage / TargetHP * 100, 1) * 100;
        }

        /// <summary>
        /// Average dmg per hit to kill with min # of hits
        /// </summary>
        public int AverageDmgPerHitToKillWithMinNoOfHits
        {
            get => _averageDmgPerHitToKillWithMinNoOfHits;
            private set
            {
                if (_averageDmgPerHitToKillWithMinNoOfHits == value)
                    return;
                _averageDmgPerHitToKillWithMinNoOfHits = value;
                OnPropertyChanged();
            }
        }
        public int BaseDamage { get; set; }
        /// <summary>
        /// Approx. chance of killing target with min # of hits
        /// </summary>
        public decimal ChanceOfKillingWithMinNoOfHits
        {
            get => _chanceOfKillingWithMinNoOfHits;
            private set
            {
                if (_chanceOfKillingWithMinNoOfHits == value)
                    return;
                _chanceOfKillingWithMinNoOfHits = value;
                OnPropertyChanged();
            }
        }
        public int MaxDamageDealt
        {
            get => _maxDamageDealt;
            private set
            {
                if (_maxDamageDealt == value)
                    return;
                _maxDamageDealt = value;
                OnPropertyChanged();
            }
        }
        public int MaxDamageWithMinNoOfHits
        {
            get => _maxDamageWithMinNoOfHits;
            private set
            {
                if (_maxDamageWithMinNoOfHits == value)
                    return;
                _maxDamageWithMinNoOfHits = value;
                OnPropertyChanged();
            }
        }
        public int MaximumDamage
        {
            get => _maximumDamage;
            private set
            {
                if (_maximumDamage == value)
                    return;
                _maximumDamage = value;
                OnPropertyChanged();
            }
        }
        public int MaxNumberOfHits
        {
            get => _maxNumberOfHits;
            private set
            {
                if (_maxNumberOfHits == value)
                    return;
                _maxNumberOfHits = value;
                OnPropertyChanged();
            }
        }
        public int MinDamageDealt
        {
            get => _minDamageDealt;
            private set
            {
                if (_minDamageDealt == value)
                    return;
                _minDamageDealt = value;
                OnPropertyChanged();
            }
        }
        public int MinimumDamage
        {
            get => _minimumDamage;
            private set
            {
                if (_minimumDamage == value)
                    return;
                _minimumDamage = value;
                OnPropertyChanged();
            }
        }
        public int MinNumberOfHits
        {
            get => _minNumberOfHits;
            private set
            {
                if (_minNumberOfHits == value)
                    return;
                _minNumberOfHits = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<MultiplierModel> Multipliers { get; } = new ObservableCollection<MultiplierModel>();
        public decimal OneShotChance
        {
            get => _oneShotChance;
            private set
            {
                if (_oneShotChance == value)
                    return;
                _oneShotChance = value;
                OnPropertyChanged();
            }
        }
        public int TargetHP { get; set; }

    }
}
