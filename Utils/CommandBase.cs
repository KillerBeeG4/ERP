using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ERP.Utils
{
    class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Predicate<object> _predicate;
        private Action<object> _action;

        public CommandBase(Predicate<object> canExecute, Action<object> execute)
        {
            _predicate = canExecute;
            _action = execute;
        }

        public bool CanExecute(object parameter)
        {
            return _predicate(parameter);
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
