using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PocketHome.Web.Controllers
{
    public class DesignController : Controller
    {
	    
	    public DesignController()
	    {
	    }

	    public IActionResult Index()
	    {
		    return View();
	    }
		
    }
}
