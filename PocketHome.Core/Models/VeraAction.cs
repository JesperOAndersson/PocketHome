namespace PocketHome.Core.Models
{
    public class VeraAction
    {
		public int VeraActionId { get; set; }
		public string DeviceId { get; set; }
		public CategoryEnum DeviceType { get; set; }
		public string Action { get; set; }
    }
}
