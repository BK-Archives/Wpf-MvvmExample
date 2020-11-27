using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmExample.Logic.UserInteraction
{
	public interface IUserInteraction
	{
		UserInteractionResult DisplayAlert(string title, string prompt, UserInteractionOption option = UserInteractionOption.YesNo);
	}
}
