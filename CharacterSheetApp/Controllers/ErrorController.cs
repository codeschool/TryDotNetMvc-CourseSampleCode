using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApp.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
