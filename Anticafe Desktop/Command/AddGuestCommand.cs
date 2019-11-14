using System;
using System.Windows.Input;

namespace Anticafe
{
	public class AddGuestCommand : RelayCommand
	{
		public AddGuestCommand(Action<object> execute, Func<object, bool> canExecute = null) : base(execute, canExecute) { }

		public override bool CanExecute(object parameter)
		{
			//Добавить проверку
			return false;
		}
		public override void Execute(object parameter)
		{
			//что исполнять
		}
	}
}
