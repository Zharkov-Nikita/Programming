using System;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует класс выполнения команд.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Определяет метод, вызываемый при вызове данной команды.
        /// </summary>
        private Action<object> execute;

        /// <summary>
        /// Определяет, может ли команда выполняться в текущем состоянии.
        /// </summary>
        private Func<object, bool> canExecute;

        /// <summary>
        /// Происходит, когда диспетчер команд обнаруживает изменение источника команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса  <see cref="RelayCommand"/>.
        /// </summary>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Определяет, может ли команда выполняться в текущем состоянии.
        /// </summary>
        /// <param name="parameter">Данные, используемые данной командой.</param>
        /// <returns>true</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Определяет метод, вызываемый при вызове данной команды.
        /// </summary>
        /// <param name="parameter">Данные, используемые данной командой.</param>
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
