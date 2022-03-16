using Project.AdventureWorks2014.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.AdventureWorks2014.Business.Abstract
{
	public interface ICategoryService
	{
		List<Category> GetAll();
	}
}
