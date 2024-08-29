using Microsoft.AspNetCore.Mvc;

namespace MVCWeb.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
