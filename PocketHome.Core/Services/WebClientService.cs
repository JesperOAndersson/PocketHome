using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PocketHome.Core.Services
{
	public interface IWebClientService
	{
		Task<Task<T>> GetJson<T>(string url);

	}
	public class WebClientService : IWebClientService
	{
		public async Task<Task<T>> GetJson<T>(string url)
		{
			using (var client = new HttpClient())
			{
				var json = client.GetAsync(url);
				var temp = await json;
				var jsonString = await temp.Content.ReadAsStringAsync();
				return Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(jsonString));
				
				
			}
		}
	}
}
