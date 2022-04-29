using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GameStore.commands
{
    class BaseCommands : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<object> execute;
        private Func<object, bool> canexecute;

        public BaseCommands(Action<object> execute, Func<object, bool> canexecute = null)
        {
            this.execute = execute;
            this.canexecute = canexecute;
        }

        public event EventHandler? CanExecuteChanger
        {
            add {CommandManager.RequerySuggested += value;}
            remove {CommandManager.RequerySuggested -= value;}
        }

        public bool CanExecute(object? parameter)
        {
            return this.canexecute == null || this.canexecute(parameter);
        }

        public void Execute(object? parameter)
        {
            this.execute(parameter);
        }
    }
}
