using System;
using Microsoft.EntityFrameworkCore;
namespace exam_sem3_mvc.Entities
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions options): base(options) { 
		
		}

		public DbSet<Department> department { get; set; }
		public DbSet<Staff> Staff { get; set; }
	}
}
