using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PocketHome.Core.Services;
namespace PocketHome.Web.Controllers
{
	public class DeviceController : Controller
    {
	    private readonly IVeraService _veraService;

	    public DeviceController(IVeraService veraService)
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

	    public bool ToggleLight(int id, int toggle)
	    {
		    _veraService.ToggleLight(id, toggle);
			//clear cache
		    return true;
	    }
    }
}
