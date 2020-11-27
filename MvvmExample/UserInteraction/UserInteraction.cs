using System.Windows;
using MvvmExample.Logic.UserInteraction;

namespace MvvmExample.UserInteraction
{
	class UserInteraction : IUserInteraction
	{

		public UserInteractionResult DisplayAlert(string title, string prompt, UserInteractionOption option = UserInteractionOption.YesNo)
		{
			var result = MessageBox.Show(prompt, title, (MessageBoxButton)option);
			return (UserInteractionResult) result;
		}
	}
}
