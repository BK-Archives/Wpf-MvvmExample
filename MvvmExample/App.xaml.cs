﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MvvmExample.Logic;

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

			var mainWindowViewModel = new MainWindowViewModel();
			var mainWindow = new MainWindow();
			mainWindow.DataContext = mainWindowViewModel;

			MainWindow = mainWindow;
			MainWindow.Show();
		}
	}
}
