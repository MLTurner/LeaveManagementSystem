using leave_management_system.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace leave_management_system.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC Mastery",
                DateofBirth = new DateTime(1954, 12, 01)
            };
            return View(data);
        }
    }
}
