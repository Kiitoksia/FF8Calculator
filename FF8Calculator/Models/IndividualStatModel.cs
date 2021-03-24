using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class IndividualStatModel : BaseModel
    {

        private StatJunctionModel ability;
        private int amount;
        private int multiplier = 0;

        private IndividualStatModel(JunctionType type)
        {
            Type = type;
        }

        public StatJunctionModel Ability
        {
            get => ability; 
            set
            {
                if (ability == value)
                    return;
                ability = value;
                OnPropertyChanged();
            }
        }
        public int Amount
        {
            get => amount; 
            set
            {
                if (amount == value)
                    return;
                amount = value;
                OnPropertyChanged();
            }
        }
        public int Multiplier
        {
            get => multiplier; 
            set
            {
                if (multiplier == value)
                    return;
                multiplier = value;
                OnPropertyChanged();
            }
        }

        public JunctionType Type { get; }

        public static void Create(StatCalculatorModel model, JunctionType type)
        {
            IndividualStatModel stat = new IndividualStatModel(type);
            stat.PropertyChanged += (s, e) =>
            {
                model.OnPropertyChanged(nameof(StatCalculatorModel.Stats));
            };

            model.Stats.Add(stat);
        }

        private int output;
        public int Output
        {
            get => output; private set
            {
                if (output == value)
                    return;
                output = value;
                OnPropertyChanged();
            }
        }

        private bool _isCalculating = false;

        public void Calculate(EnemyModel player)
        {
            if (_isCalculating) return;
            _isCalculating = true;

            if (player == null)
            {
                Output = 0;
                _isCalculating = false;
                return;
            }

            decimal amount = player.GetStat(Type);
            if (Amount > 0 && Ability != null)
            {
                amount += Ability.GetStat(Type) * Amount;
            }

            amount *= 1 + (Multiplier / 100m);
            Output = RoundDown(amount);
            _isCalculating = false;
        }

    }
}
