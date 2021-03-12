using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class MultiplierModel : BaseModel
    {

        private bool isTicked;
        private decimal multiplier;
        private string name;


        public static void Create(BaseDamageModel viewModel, string name, decimal multiplier)
        {
            MultiplierModel model = new MultiplierModel(name, multiplier);
            model.PropertyChanged += (s, e) =>
            {
                viewModel.OnPropertyChanged(nameof(BaseDamageModel.Multipliers));
            };

            viewModel.Multipliers.Add(model);
        }

        private MultiplierModel(string name, decimal multiplier)
        {
            Name = name;
            Multiplier = multiplier; 
        }

        public bool IsTicked
        {
            get => isTicked; set
            {
                if (isTicked == value)
                    return;
                isTicked = value;
                OnPropertyChanged();
            }
        }

        public decimal Multiplier
        {
            get => multiplier; set
            {
                if (multiplier == value)
                    return;
                multiplier = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => name; set
            {
                if (name == value)
                    return;
                name = value;
                OnPropertyChanged();
            }
        }

    }
}
