using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YoctoWPF.Mvvm.Input
{
    public class RelayCommand<TContext> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action<TContext> _execute;
        private readonly Predicate<TContext> _canExecute;

        public RelayCommand(Action<TContext> execute)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));
            _execute = execute;
        }

        public RelayCommand(Action<TContext> execute, Predicate<TContext> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException(nameof(execute));
            if (canExecute == null)
                throw new ArgumentNullException(nameof(canExecute));
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || 
                   (parameter == null && _canExecute(default(TContext))) || 
                   (parameter != null && parameter is TContext && _canExecute((TContext)parameter));
        }

        public void Execute(object parameter)
        {
            if (parameter is TContext context)
            {
                _execute?.Invoke(context);
            }
            else if (parameter == null)
            {
                _execute?.Invoke(default(TContext));
            }
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
