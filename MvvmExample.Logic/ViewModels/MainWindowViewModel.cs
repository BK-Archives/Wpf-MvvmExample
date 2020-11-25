using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using MvvmExample.DataAccess;
using MvvmExample.DataAccess.Models;
using MvvmExample.Logic.ModelViewModels;

namespace MvvmExample.Logic
{
	public class MainWindowViewModel : ViewModelBase
	{
		private string _title;

		private readonly ItemRepository _itemRepository;

		public MainWindowViewModel() 
		{
			_itemRepository = new ItemRepository(); // you would normally use DI

			Title = "This is a title";

			LoadItemsCommand = new RelayCommand(_ =>
			{
				var items = _itemRepository.GetItems(); // this returns the models! // we have to wrap them by a viewmodel
				var itemViewModels = items.Select(item => new ItemViewModel(item)); // no we wrapped them in a viewmodel
				Items.Clear();
				foreach (var itemViewModel in itemViewModels) 
					Items.Add(itemViewModel);
			});

			ClearItemsCommand = new RelayCommand(_ => Items.Clear());
		}

		public ObservableCollection<ItemViewModel> Items { get; private set; } = new ObservableCollection<ItemViewModel>();

		public ICommand LoadItemsCommand { get; }
		public ICommand ClearItemsCommand { get; }

		public string Title
		{
			get => _title;
			set => SetProperty(ref _title, value);
		}

	
	}
}
