using Microsoft.AspNetCore.Mvc;

namespace Phamarcy_Management__System.Controllers
{
    public class Pharmacy : Controller
    {
        public IActionResult PharmacistLandingPage()
        {
            ViewData["Title"] = "Pharmacist Landing Page";
            return View();
        }
    }
}
