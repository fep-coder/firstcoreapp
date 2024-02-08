using Microsoft.AspNetCore.Mvc;

namespace Customers.Controllers
{
        public class HomeController : Controller
        {

                public IActionResult Index()
                {
                        return View();
                }

                public ViewResult CustomerForm()
                {
                        return View();
                }

        }
}
