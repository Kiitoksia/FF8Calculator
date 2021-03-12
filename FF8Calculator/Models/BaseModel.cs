using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public abstract class BaseModel : INotifyPropertyChanged
    {
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        protected int RoundDown(decimal value) => Math.Min((int)decimal.Floor(value), 9999);
        protected int RoundUp(decimal value) => Math.Min((int)decimal.Ceiling(value), 9999);
    }
}
