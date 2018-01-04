using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
	[Table("Locations")]
	public class Location
	{
		public Location()
		{
			this.Experiences = new HashSet<Experience>();
		}
		[Key]
		public int id { get; set; }
		public string name { get; set; }
        public string description { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
	}
}
