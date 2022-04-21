using Microsoft.AspNetCore.Mvc;

namespace HPCL_WebApi.Controllers
{
    public class CustomerAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
