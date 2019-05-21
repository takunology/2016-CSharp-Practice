using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace STEP5_データバインディングの活用
{
    public class DelegateCommand : ICommand
    {
        private readonly Action execute;
        private readonly Func<bool> canExecute;
        private Action p;

        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public DelegateCommand(Action p)
        {
            this.p = p;
        }

        public void Execute(object parameter)
        {
            this.execute();
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute();
        }

        public event EventHandler CanExecuteChanged;

    }
}
