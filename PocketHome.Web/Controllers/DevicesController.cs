using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PocketHome.Core.Services;

namespace PocketHome.Web.Controllers
{
    [Authorize]
	public class DevicesController : Controller
    {
	    private readonly IVeraService _veraService;

	    public DevicesController(IVeraService veraService)
	    {
		    _veraService = veraService;
	    }

	    public async Task<IActionResult> Index()
	    {
		    var data = await _veraService.GetSData();
		    var datatemp = await data;
		    return View(datatemp);
	    }

	    public async Task<IActionResult> Device(int id)
	    {
		    var data = await _veraService.GetDevice(id);
			var dataTemp = await data;
		    return View(dataTemp);
	    }
    }
}
