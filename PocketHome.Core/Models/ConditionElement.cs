namespace PocketHome.Core.Models
{
    public class ConditionElement
    {
		public int ConditionElementId { get; set; }
		public ConditionType Type { get; set; }
		public int DeviceId { get; set; }
		public int EventId {get; set; }
		public int Order { get; set; }
		public string Time { get; set; }
		public string Temp { get; set; }
		public string Light { get; set; }

    }
}
