using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using MvvmExample.DataAccess;
using MvvmExample.Logic;
using MvvmExample.Logic.ViewModels;

namespace MvvmExample
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			var itemRepository = new ItemRepository();
			var userInteraction = new UserInteraction.UserInteraction();
			var mainWindowViewModel = new MainWindowViewModel(itemRepository, userInteraction);

			var mainWindow = new MainWindow();
			mainWindow.DataContext = mainWindowViewModel;

			MainWindow = mainWindow;
			MainWindow.Show();
		}
	}
}
