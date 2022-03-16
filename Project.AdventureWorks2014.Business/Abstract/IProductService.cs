using Project.AdventureWorks2014.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.AdventureWorks2014.Business.Abstract
{
	public interface IProductService
	{
		List<Product> GetAll();
		List<Product> GetByCategory(int categoryId);//ürünü kategori idye göre listeleme
		void Add(Product product);
		void Update(Product product);
		void Delete(int productId);
	}
}
