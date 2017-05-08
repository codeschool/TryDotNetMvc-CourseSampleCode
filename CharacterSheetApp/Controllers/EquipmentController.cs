using CharacterSheetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharacterSheetApp.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            return View(Equipment.GetAll());
        }

        public IActionResult Create(string EquipmentName)
        {
            Equipment.Create(EquipmentName);
            return RedirectToAction("Index", "Equipment");
        }
    }
}
