using Microsoft.AspNetCore.Mvc;

namespace Crito.Controllers
{
    public class ContactsController : Controller
    { 


        public IActionResult Index()
        {
            return View();
        }
    }
}
