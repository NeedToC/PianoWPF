using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YoctoWPF.Mvvm.Input
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));
            _execute = execute;
        }

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));
            if (canExecute == null)
                throw new ArgumentNullException(nameof(canExecute));
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object _)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object _)
        {
            _execute?.Invoke();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}