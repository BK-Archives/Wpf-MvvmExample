using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MvvmExample.Logic
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public event PropertyChangingEventHandler PropertyChanging;

		protected void SetProperty<T>(ref T field, in T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) return;
			OnPropertyChanging(propertyName);
			field = value;
			OnPropertyChanged(propertyName);
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		protected virtual void OnPropertyChanging([CallerMemberName] string propertyName = null) =>
			PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

	}
}
