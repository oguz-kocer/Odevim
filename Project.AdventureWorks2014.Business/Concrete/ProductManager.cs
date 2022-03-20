﻿using Project.AdventureWorks2014.Business.Abstract;
using Project.AdventureWorks2014.DataAccess.Abstract;
using Project.AdventureWorks2014.DataAccess.Concrete.EntityFramework;
using Project.AdventureWorks2014.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.AdventureWorks2014.Business.Concrete
{
	public class ProductManager : IProductService
	{
		private IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}
		public void Add(Product product)
		{
			_productDal.Add(product);
		}

		public void Delete(int productId)
		{
			_productDal.Delete(new Product { ProductID=productId});
		}

		public List<Product> GetAll()
		{
			return _productDal.GetList();
		}

		public List<Product> GetByCategory(int categoryId)
		{
			return _productDal.GetList(p => p.CategoryId == categoryId);
		}

		public void Update(Product product)
		{
			_productDal.Update(product);
		}
	}
}
