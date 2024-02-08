using Customers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Controllers
{
        public class HomeController : Controller
        {

                public IActionResult Index()
                {
                        return View();
                }

                [HttpGet]
                public ViewResult CustomerForm()
                {
                        return View();
                }

                [HttpPost]
                public ViewResult CustomerForm(Customer customer)
                {
                        Repository.AddResponse(customer);
                        return View("Thanks", customer);
                }

                public ViewResult ListReturners()
                {
                        return View(Repository.Responses.Where(r => r.WillBuyAgain == true));
                }

        }
}
