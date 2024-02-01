using ClientDataManagement.MainWindowLibrary.ViewModel.Commands.Base;
using System;

namespace ClientDataManagement.MainWindowLibrary.ViewModel.Commands
{
    public class RelayCommands : Command
    {
        /// <summary>
        /// Private readonly property that execute an action that takes a parameter of type object
        /// </summary>
        private readonly Action<object> _Execute;
        /// <summary>
        /// Private readonly property that returns a function
        /// </summary>
        private readonly Func<object, bool> _CanExecute;

        /// <summary>
        /// RelayCommands
        /// </summary>
        /// <param name="Execute">Action</param>
        /// <param name="CanExecute">Function</param>
        public RelayCommands(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        /// <summary>
        /// The code is a method which takes an object parameter and returns true if the method can execute, or false otherwise.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;
        /// <summary>
        /// The code attempts to be executed when the user clicks on a button.
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object parameter) => _Execute(parameter);
    }
}
