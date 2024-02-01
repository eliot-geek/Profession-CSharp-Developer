using ClientDataManagement.MainWindowLibrary.ViewModel.Commands.Base;
using System.Windows;

namespace ClientDataManagement.ViewModels.Commands
{
    /// <summary>
    /// Command for closing the application, inherits from Command.
    /// </summary>
    internal class CloseApplicationCommand : Command
    {
        /// <summary>
        /// Determines if the command can be executed.
        /// </summary>
        /// <param name="parameter">The command parameter.</param>
        /// <returns>True always.</returns>
        public override bool CanExecute(object parameter) => true;

        /// <summary>
        /// Executes the command to shut down the application.
        /// </summary>
        /// <param name="parameter">The command parameter.</param>
        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
