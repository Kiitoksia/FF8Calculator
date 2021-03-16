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
        private decimal _baseDamage;
        private decimal _baseDamageWithoutMultipliers;
        private bool _percentageCalculating;



        public BaseDamageModel()
        {
            DamageRolls = new ObservableCollection<int>();
            Multipliers.CollectionChanged += (s, e) => OnPropertyChanged(nameof(Multipliers));
            PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(Multipliers))
                {
                    Calculate();
                }
            };

            CalculatePercentageCommand = new Command(() => true, CalculateChangeOfKillingWithMinNoofHits);
        }

        private void CalculateChangeOfKillingWithMinNoofHits()
        {
            PercentageCalculating = true;
            DamageRolls.Clear();
            _killableCombos = 0;
            _currentHP = 0;

            for (int i = 0; i < 32; i++)
            {
                int damageRoll = RoundDown(BaseDamageWithoutMultipliers * (i + 240) / 256);
                damageRoll = ApplyMultipliers(damageRoll);
                if (damageRoll == 0) continue;
                DamageRolls.Add(damageRoll);
            }
           
            if (DamageRolls.Count == 0) return;

            // TODO
            double total = Math.Pow(33, MinNumberOfHits);


            if (MaxNumberOfHits == 1)
            {
                ChanceOfKillingWithMinNoOfHits = 100; // Lowest damage roll always kills in one hit                
            }
            else if (MaxNumberOfHits == MinNumberOfHits)
            {
                ChanceOfKillingWithMinNoOfHits = 100; // We always kill in the same amount of hits
            }
            else
            {
                double killableCombos = (double)RecursiveCheck(DamageRolls.Reverse().ToArray(), MinNumberOfHits, TargetHP);

                decimal percent = (decimal)(killableCombos / total);
                ChanceOfKillingWithMinNoOfHits = percent * 100;
            }     
            
            PercentageCalculating = false;
        }

        public ObservableCollection<int> DamageRolls { get; private set; }

        private double _killableCombos = 0;        
        private int _currentHP = 0;

        private double RecursiveCheck(int[] damageRolls, int hitsLeft, int targetHP)
        {
            if (hitsLeft == 0) return 0;

            // We start at max damage rolls and work our way down

            _killableCombos = 0;


            for (int i = 0; i < 32; i++)
            {
                int damage = damageRolls[i];

                if (damage >= targetHP)
                {
                    // This damage roll kills
                    _killableCombos++;
                }
                else
                {
                    // Damage roll does not kill outright, lower HP/hits and run again
                    _currentHP = targetHP - damage;
                    //remainingHP -= damage;                    
                    _killableCombos += RecursiveCheck(damageRolls, hitsLeft - 1, _currentHP);
                }
            }

            return _killableCombos;
        }

        protected int ApplyMultipliers(int value)
        {
            decimal multipliedValue = value;
            foreach (MultiplierModel multiplier in Multipliers.Where(t => t.IsTicked))
            {
                multipliedValue *= multiplier.Multiplier;
            }

            return Math.Min(RoundDown(multipliedValue), 9999);
        }

        protected decimal ApplyMultipliers(decimal value)
        {
            foreach (MultiplierModel multiplier in Multipliers.Where(t => t.IsTicked))
            {
                value = value * multiplier.Multiplier;
            }

            return Math.Min(value, 9999);
        }

        /// <summary>
        /// Requires BaseDamage/TargetHP to be set
        /// </summary>
        public virtual void Calculate()
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

            int[] damageRolls = Enumerable.Range(0, 32).Select(t => ApplyMultipliers(RoundDown(BaseDamageWithoutMultipliers * (t + 240) / 256))).ToArray();

            damageRolls = damageRolls.Where(t => t > 0).ToArray();
            if (damageRolls.Length == 0) return;

            MinimumDamage = damageRolls.First();
            MaximumDamage = damageRolls.Last();

            for (int i = 0; i < 32; i++)
            {
                int dmgRoll = damageRolls[i % damageRolls.Length];
                if (dmgRoll >= TargetHP)
                {
                    OneShotChance = decimal.Round((32m - i) / 32 * 100, 2, MidpointRounding.AwayFromZero);
                    break;
                }
            }

            MinNumberOfHits = RoundUp((decimal)TargetHP / MaximumDamage);
            MaxNumberOfHits = RoundUp((decimal)TargetHP / MinimumDamage);

            MinDamageDealt = MinNumberOfHits * MinimumDamage;
            MaxDamageDealt = MaxNumberOfHits * MaximumDamage;

            MaxDamageWithMinNoOfHits = MaximumDamage * MinNumberOfHits;
            AverageDmgPerHitToKillWithMinNoOfHits = RoundUp((decimal)TargetHP / MinNumberOfHits);
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

        public decimal BaseDamage
        {
            get => _baseDamage; 
            protected set
            {
                if (_baseDamage == value)
                    return;
                _baseDamage = value;
                OnPropertyChanged();
            }
        }

        public decimal BaseDamageWithoutMultipliers
        {
            get => _baseDamageWithoutMultipliers; 
            protected set
            {
                if (_baseDamageWithoutMultipliers == value)
                    return;
                _baseDamageWithoutMultipliers = value;
                OnPropertyChanged();
            }
        }

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

        public Command CalculatePercentageCommand { get; }

        public bool PercentageCalculating
        {
            get => _percentageCalculating; 
            private set
            {
                if (_percentageCalculating == value)
                    return;
                _percentageCalculating = value;
                OnPropertyChanged();
            }
        }
    }
}
