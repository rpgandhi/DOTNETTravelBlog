using System;
using Microsoft.EntityFrameworkCore;

namespace Rename.Models
{
	public class RenameContext : DbContext
	{
		//public DbSet<Item> Items { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder
				.UseMySql(@"Server=localhost;Port=8889;database=todolist;uid=root;pwd=root;");
	}
}
