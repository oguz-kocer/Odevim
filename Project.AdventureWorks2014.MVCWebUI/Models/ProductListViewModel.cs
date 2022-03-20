using System.Collections.Generic;
using Project.AdventureWorks2014.Entities.Concrete;

namespace Project.AdventureWorks2014.MVCWebUI.Models
{
	public class ProductListViewModel
	{
		public List<Product> Products { get; internal set; }
		public List<Product> Product { get; internal set; }
	}
}
