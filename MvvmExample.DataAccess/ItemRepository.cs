using System;
using System.Collections.Generic;
using System.Text;
using MvvmExample.DataAccess.Models;

namespace MvvmExample.DataAccess
{
	public class ItemRepository
	{
		public IEnumerable<Item> GetItems()
		{
			yield return new Item("Apple", "1");
			yield return new Item("Banana", "2");
			yield return new Item("Water", "3");
			yield return new Item("Coke", "4");
		}
	}
}
