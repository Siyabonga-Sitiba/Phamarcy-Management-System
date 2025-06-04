using Phamarcy_Management__System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Phamarcy_Management__System.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult CustomerSignUp()
        {
            // Dummy allergy list for dropdown
            ViewBag.Allergies = new SelectList(new List<string>
            {
                "None",
                "Peanuts",
                "Penicillin",
                "Pollen",
                "Dust",
                "Latex"
            });

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register()
        {
            // Redirect to Dashboard regardless of input
            return RedirectToAction("Dashboard");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login()
        {
            // Redirect to Dashboard regardless of input
            return RedirectToAction("Dashboard");
        }

        private static List<PrescriptionViewModel> _prescriptions = new();

            public IActionResult Dashboard()
            {

            string customerName = "Leana Deebb"; // replace with actual logic

            ViewBag.CustomerName = customerName;
            ViewBag.TotalPrescriptions = _prescriptions.Count;
                ViewBag.TotalRepeats = _prescriptions.Sum(p => p.RepeatsLeft);
                return View();
            }

           

            // Manage repeats
            public IActionResult ManageRepeats()
            {
                // Just showing current prescriptions with repeats left
                return View();
            }

            // Generate Report (GET)
            public IActionResult GenerateReport()
            {
                return View();
            }

            // Generate Report (POST) - dummy PDF generation
            [HttpPost]
            public IActionResult GenerateReport(DateTime fromDate, DateTime toDate, string groupBy)
            {
                // Normally generate a PDF report - here just show a dummy confirmation message
                TempData["Success"] = $"Report generated from {fromDate:d} to {toDate:d}, grouped by {groupBy}.";
                return RedirectToAction(nameof(GenerateReport));
            }
        }

        // ViewModel for Prescription
        public class PrescriptionViewModel
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public DateTime UploadDate { get; set; }
            public int RepeatsLeft { get; set; }
            public Microsoft.AspNetCore.Http.IFormFile UploadedFile { get; set; }
            public string FileName => UploadedFile?.FileName ?? "Uploaded PDF";
        }
    }



