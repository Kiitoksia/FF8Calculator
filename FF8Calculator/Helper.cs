using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Markup;

namespace FF8Calculator
{
    public class EnumSourceExtension : MarkupExtension
    {
        private Type _type;
        public EnumSourceExtension(Type type)
        {
            _type = type;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(_type);
        }
    }

    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Func<bool> _canExecuteMethod;
        private Action _executeMethod;

        public Command(Func<bool> canExecute, Action execute)
        {
            _canExecuteMethod = canExecute;
            _executeMethod = execute;
        }


        public bool CanExecute(object parameter)
        {            
            return _canExecuteMethod();
        }

        public void Execute(object parameter) => _executeMethod();
    }
}
