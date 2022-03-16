using Microsoft.EntityFrameworkCore;
using Project.AdventureWorks2014.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.AdventureWorks2014.DataAccess.Concrete.EntityFramework
{
	public class AdvanturaWorks2014Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AdventureWorks2014; Trusted_Connection=true");
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
