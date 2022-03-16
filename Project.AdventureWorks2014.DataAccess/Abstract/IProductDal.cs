using Project.AdventureWorks2014.Entities.Concrete;
using Project.Core.DataAccess;

namespace Project.AdventureWorks2014.DataAccess.Abstract
{
	public interface IProductDal : IEntityRepository<Product>
	{
		void Delete(int productId);
	}
}
