using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmExample.DataAccess.Models
{
	public class Item
	{
		public Item() { }

		public Item(string name, string price)
		{
			Name = name;
			Price = price;
		}

		public string Name { get; set; }
		public string Price { get; set; } // using string to stay simple // otherwise you would use a valueconverter
	}
}
