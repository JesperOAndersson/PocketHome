using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocketHome.Core.Models
{
	public class Room
	{
        [Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public int? Section { get; set; }
	    [ForeignKey("Device")]
        public ICollection<Device> Devices { get; set; }
	    [ForeignKey("Scene")]
        public ICollection<Scene> Scenes { get; set; }
        [ForeignKey("Section")]
		public Section Section1 { get; set; }
	}
}
