using System;
using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Models
{
	public class TravelBlogContext : DbContext
	{
		public DbSet<Location> Locations { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder
				.UseMySql(@"Server=localhost;Port=8889;database=TravelBlog;uid=root;pwd=root;");
	}
}
