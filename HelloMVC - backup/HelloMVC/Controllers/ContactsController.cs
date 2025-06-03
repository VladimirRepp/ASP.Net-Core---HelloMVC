using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
