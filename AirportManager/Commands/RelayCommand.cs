using System.Windows.Input;

namespace AirportManager.Commands
{
    public class RelayCommand(Action<object> executeAction) : ICommand
    {
        private readonly Action<object> _executeAction = executeAction;

        public bool CanExecute(object? parameter) => true;
        public void Execute(object? parameter)
        {
            if (parameter != null)
            {
                _executeAction(obj: parameter);
            }
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
