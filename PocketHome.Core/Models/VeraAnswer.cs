using System.Collections.Generic;

namespace PocketHome.Core.Models
{
	public class VeraAnswer
	{
		public int full { get; set; }
		public string version { get; set; }
		public string model { get; set; }
		public int zwave_heal { get; set; }
		public string temperature { get; set; }
		public string skin { get; set; }
		public string serial_number { get; set; }
		public string fwd1 { get; set; }
		public string fwd2 { get; set; }
		public int mode { get; set; }
		public List<Section> sections { get; set; }
		public List<Room> rooms { get; set; }
		public List<Scene> scenes { get; set; }
		public List<Device> devices { get; set; }
		public List<Category> categories { get; set; }
		public int ir { get; set; }
		public string irtx { get; set; }
		public int loadtime { get; set; }
		public int dataversion { get; set; }
		public int state { get; set; }
		public string comment { get; set; }
	}
}
