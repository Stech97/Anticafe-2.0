using System;
using System.Windows.Input;

namespace Anticafe.ViewModel
{
	public class StartWindowCommand : ICommand
	{
		private readonly Action<object> _execute;
		private readonly Func<object, bool> _canExecute;

		public event EventHandler CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}

		public StartWindowCommand(Action<object> execute, Func<object, bool> canExecute = null)
		{
			_execute = execute;
			_canExecute = canExecute;
		}

		public bool CanExecute(object parameter) => this._canExecute == null || this._canExecute(parameter);

		public void Execute(object parameter) => _execute(parameter);
	}
}
