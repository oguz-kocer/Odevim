using Project.AdventureWorks2014.Business.Abstract;
using Project.AdventureWorks2014.DataAccess.Abstract;
using Project.AdventureWorks2014.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.AdventureWorks2014.Business.Concrete
{
	internal class CategoryManager : ICategoryService
	{
		private ICategoryDal _categoryDal;
		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}
		public List<Category> GetAll()
		{
			return _categoryDal.GetList();
		}
	}
}
