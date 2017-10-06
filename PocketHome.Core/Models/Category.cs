using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketHome.Core.Models
{

	public class Category
	{
        [Key]
		public int Id { get; set; }
		public string Name { get; set; }
	    [ForeignKey("Device")]
        public ICollection<Device> Devices { get; set; }
	}
}
