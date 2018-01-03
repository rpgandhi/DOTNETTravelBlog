using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rename.Models
{
	[Table("Items")]
	public class Item
	{
		[Key]
		public int ItemId { get; set; }
		public string Description { get; set; }
	}
}
