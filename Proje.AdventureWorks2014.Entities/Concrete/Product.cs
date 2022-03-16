using Project.Core.Entities;

namespace Project.AdventureWorks2014.Entities.Concrete
{
	public class Product : IEntity
	{
		public int ProductID { get; set; }
		public string Name { get; set; }
		public int ProductSubcategoryID { get; set; }
		public decimal ListPrice { get; set; }
		public short SafetyStockLevel { get; set; }
	}
}
