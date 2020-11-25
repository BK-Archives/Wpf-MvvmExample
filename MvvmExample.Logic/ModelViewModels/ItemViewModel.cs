using System;
using System.Collections.Generic;
using System.Text;
using MvvmExample.DataAccess.Models;

namespace MvvmExample.Logic.ModelViewModels
{
	public class ItemViewModel : ViewModelBase
	{
		private string _name;
		private string _price;

		public ItemViewModel(Item item)
		{
			Name = item.Name;
			Price = item.Price;
		}

		public string Name
		{
			get => _name;
			set => SetProperty(ref _name, value);
		}

		public string Price
		{
			get => _price;
			set => SetProperty(ref _price, value);
		}
	}
}
