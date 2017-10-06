using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PocketHome.Core.Models
{
	public class Section
	{
		public int Id { get; set; }
		public string Name { get; set; }
        [ForeignKey("Room")]
		public ICollection<Room> Rooms { get; set; }
	}
}