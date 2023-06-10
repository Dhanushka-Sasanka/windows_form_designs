using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class AppDbContext : DbContext
	{

		public AppDbContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
		{ 
		
		}

		public DbSet<Employee> EmployeeTable { get; set; }

		
	}
}
