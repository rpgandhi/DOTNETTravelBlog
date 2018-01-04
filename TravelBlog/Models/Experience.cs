using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
	[Table("Experiences")]
	public class Experience
	{
		[Key]
		public int id { get; set; }
		public string title { get; set; }
		public string description { get; set; }
        public virtual int locationId { get; set; }
	}
}