using CharacterSheetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApp.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult Index()
        {
            return View(Character.GetAll());
        }

        public IActionResult Create(string CharacterName)
        {
            Character.Create(CharacterName);
            return RedirectToAction("Index", "Character");
        }
    }
}
