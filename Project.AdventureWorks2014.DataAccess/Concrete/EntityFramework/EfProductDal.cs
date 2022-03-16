using Project.AdventureWorks2014.DataAccess.Abstract;
using Project.AdventureWorks2014.Entities.Concrete;
using Project.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.AdventureWorks2014.DataAccess.Concrete.EntityFramework
{
	public class EfProductDal:EfEntityRepositoryBase<Product,AdventureWorks2014Context>,IProductDal
	{

	}
}
