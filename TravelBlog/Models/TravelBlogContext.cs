using System;
using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Models
{
	public class TravelBlogContext : DbContext
	{
		public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder
				.UseMySql(@"Server=localhost;Port=8889;database=TravelBlog;uid=root;pwd=root;");
	}
}
