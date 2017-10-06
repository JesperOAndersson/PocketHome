namespace PocketHome.Core.Models
{
	public class Device
	{
		public int Id { get; set; }
		public string AltId { get; set; }
		public string Name { get; set; }
		public int? Category { get; set; }
		public int? SubCategory { get; set; }
		public string Watts { get; set; }
		public string KWH { get; set; }
		public string Temperature { get; set; }
		public string Light { get; set; }
		public string Comment { get; set; }
		public int? Room { get; set; }
		public int? State { get; set; }
		public int? Status { get; set; }
		public int? Parent { get; set; }
		public string BatteryLevel { get; set; }
	}
}
