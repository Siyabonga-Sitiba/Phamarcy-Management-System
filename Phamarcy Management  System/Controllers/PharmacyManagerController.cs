using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Phamarcy_Management__System.Models;

namespace Phamarcy_Management__System.Controllers
{
    public class PharmacyManagerController : Controller
    {
        private readonly ILogger<PharmacyManagerController> _logger;

        public PharmacyManagerController(ILogger<PharmacyManagerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult ManageDoctors()
        {
            return View();
        }
        public IActionResult ManagePharmacist()
        {
            return View();
        }
        public IActionResult ManagePharmacy()
        {
            return View();
        }
        public IActionResult ManageSuppliers()
        {
            return View();
        }
        public IActionResult ManageActiveIngredients()
        {
            return View();
        }
        public IActionResult ManageDosageForm()
        {
            return View();
        }
        public IActionResult ManageMedicationRecords()
        {
            return View();
        }

        public IActionResult StockRecords()
        {
            return View();
        }

        public IActionResult StockOrders()
        {
            return View();
        }



    }
}
