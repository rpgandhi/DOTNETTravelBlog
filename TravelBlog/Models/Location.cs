using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
	[Table("Locations")]
	public class Location
	{
		[Key]
		public int id { get; set; }
		public string name { get; set; }
        public string description { get; set; }
	}
}
