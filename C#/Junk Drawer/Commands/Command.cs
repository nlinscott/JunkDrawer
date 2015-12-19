using System;
using System.Windows.Input;

namespace Junk_Drawer.Commands
{
    class Command : ICommand
    {
        private readonly Action<object> _executeCommand = null;
        private readonly Predicate<object> _canExecuteCommand = null;


        public Command(Action<object> execute)
            : this(execute, null)
        {

        }

        public Command(Action<object> execute, Predicate<object> canExecute)
        {
            _executeCommand = execute;
            _canExecuteCommand = canExecute;
        }


        #region ICommand implementation

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object param)
        {
            if (_canExecuteCommand != null)
            {
                return _canExecuteCommand(param);
            }
            //if _canExecuteCommand is null, command does not require validation
            return true;
        }

        public void Execute(object param)
        {
            if (_executeCommand != null)
            {
                _executeCommand(param);
            }
        }

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        #endregion
    }
}
