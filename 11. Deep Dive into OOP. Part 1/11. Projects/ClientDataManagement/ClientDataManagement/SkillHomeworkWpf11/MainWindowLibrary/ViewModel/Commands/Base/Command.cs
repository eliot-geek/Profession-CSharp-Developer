using System;
using System.Windows.Input;

namespace ClientDataManagement.MainWindowLibrary.ViewModel.Commands.Base
{
    /// <summary>
    /// A class that implements the ICommand interface for creating WPF commands
    /// </summary>
    public abstract class Command : ICommand
    {
        /// <summary>
        /// Event notifying about the existence of the state of the command
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// Calling the destructive method of the command
        /// </summary>
        /// <param name="parameter">Command parameter</param>
        /// <returns>True - if command execution is allowed</returns>
        public abstract bool CanExecute(object parameter);

        /// <summary>
        /// Calling the executing method of the command
        /// </summary>
        /// <param name="parameter">Command parameter</param>
        public abstract void Execute(object parameter);
    }
}
