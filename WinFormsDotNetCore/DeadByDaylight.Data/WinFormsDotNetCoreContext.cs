using WinFormsDotNetCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace WinFormsDotNetCore.Data
{
	public class WinFormsDotNetCoreContext : DbContext
	{
		public WinFormsDotNetCoreContext() { }

		public DbSet<TestEntity> TestEntity { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite(@"Data Source=Database\WinFormsDotNetCoreDB.db");
	}
}
