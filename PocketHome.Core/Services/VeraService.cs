using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IVeraControl.Model;
using IVeraControl.Service;
using PocketHome.Core.Models;

namespace PocketHome.Core.Services
{
	public interface IVeraService
	{
		Task<Task<VeraAnswer>> GetSData();
		Task<Task<Device>> GetDevice(int id);
		void ToggleLight(int id, int toggle);
	}
	public class VeraService : IVeraService
	{

		private readonly IWebClientService _webClientService;
		private readonly IVeraControllerService _veraControllerService;
		private IEnumerable<IVeraController> _controllers;
		private IVeraController _myVera;


        //TODO INSERT IP OR URL TO VERA
		private const string BasicUrl = "";

		public VeraService(IWebClientService webClientService, IVeraControllerService veraControllerService)
		{
			_webClientService = webClientService;
			_veraControllerService = veraControllerService;
			SetUp();
		}

		private async void SetUp()
		{
            //TODO INSERT ACCOUNT DETAILS
			_controllers = await _veraControllerService.GetControllers("", "");
			_myVera = _controllers.FirstOrDefault();
		}

		public async Task<Task<VeraAnswer>> GetSData()
		{
			var restUrl = "/data_request?id=sdata&output_format=json";
			return await _webClientService.GetJson<VeraAnswer>(BasicUrl + restUrl);
		}

		public async Task<Task<Device>> GetDevice(int id)
		{

			var restUrl = "/data_request?id=finddevice&devid=" + id;
			return await _webClientService.GetJson<Device>(BasicUrl + restUrl);
		}

		public void ToggleLight(int id, int toggle)
		{
			var restUrl = "/data_request?id=action&output_format=json&DeviceNum="+id+"&serviceId=urn:upnp-org:serviceId:SwitchPower1&action=SetTarget&newTargetValue=" + toggle;
			var temp = _webClientService.GetJson<string>(BasicUrl + restUrl);
		}


	}


}
