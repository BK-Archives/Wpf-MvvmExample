using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MvvmExample.DataAccess;
using MvvmExample.Logic.UserInteraction;
using MvvmExample.Logic.ViewModels;

namespace MvvmExample.Logic.Tests
{
	[TestClass]
	public class MainWindowViewModelTests
	{
		[TestMethod]
		public void ClearItemsCommand_WhenUserInteraction_ReturnsYes_ItemsShouldBeCleared()
		{
			// arrange
			var vm = Setup(UserInteractionResult.Yes);
			vm.LoadItemsCommand.Execute(null);

			// act
			vm.ClearItemsCommand.Execute(null);

			// assert
			Assert.IsTrue(vm.Items.Count == 0);
		}

		[TestMethod]
		public void ClearItemsCommand_WhenUserInteraction_ReturnsNo_ItemsShouldNotBeCleared()
		{
			// arrange
			var vm = Setup(UserInteractionResult.No);
			vm.LoadItemsCommand.Execute(null);
			var items = vm.Items;

			// act
			vm.ClearItemsCommand.Execute(null);

			// assert
			Assert.IsTrue(vm.Items.Count != 0 && vm.Items.Count == items.Count);
			Assert.AreEqual(vm.Items, items);
		}

		private MainWindowViewModel Setup(UserInteractionResult userInteractionMockResult)
		{
			var itemRepository = new ItemRepository();
			var userInteraction = new UserInteractionMock(userInteractionMockResult);
			var vm = new MainWindowViewModel(itemRepository, userInteraction);
			return vm;
		}
	}

	class UserInteractionMock : IUserInteraction
	{
		private readonly UserInteractionResult _result;

		public UserInteractionMock(UserInteractionResult result) => _result = result;

		public UserInteractionResult DisplayAlert(string title, string prompt,
			UserInteractionOption option = UserInteractionOption.YesNo)
		{
			return _result;
		}
	}
}
