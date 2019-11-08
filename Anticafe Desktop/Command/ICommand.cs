using System;

namespace Anticafe
{
	public interface ICommand
	{
		event EventHandler CanExecuteChanged;
		void Execute(object parameter);
		bool CanExecute(object parameter);
	}
}