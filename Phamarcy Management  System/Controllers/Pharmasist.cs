using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Phamarcy_Management__System.Models.PharmacistModels;

namespace Phamarcy_Management__System.Controllers
{
    public class Pharmasist:Controller
    {
        // Static data simulating a database
        private static List<PrescriptionMock> _prescriptions = new List<PrescriptionMock>();
        private static List<string> _doctors = new() { "Dr. Smith", "Dr. Johnson", "Dr. Patel" };
        private static List<MedicationInputModel> _medications = new()
        {
            new MedicationInputModel { MedicationId = 1, Name = "Paracetamol" },
            new MedicationInputModel { MedicationId = 2, Name = "Ibuprofen" },
            new MedicationInputModel { MedicationId = 3, Name = "Amoxicillin" },
        };

        // GET: Dashboard with upload and inbox tabs
        public IActionResult MYPHARMDASHBOARD()
        {
            var model = new PrescriptionUploadViewModel
            {
                AvailableDoctors = _doctors,
                AvailableMedications = _medications.Select(m => new SelectListItem
                {
                    Value = m.MedicationId.ToString(),
                    Text = m.Name
                }).ToList(),
                Medications = new List<MedicationInputModel> { new MedicationInputModel() }, // start with 1 blank medication
                Prescriptions = _prescriptions.OrderByDescending(p => p.PrescriptionDate).ToList()
            };
            return View(model);
        }

        // POST: Upload prescription
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public IActionResult UploadPrescription(PrescriptionUploadViewModel model)
        //{
        //    // repopulate dropdown lists on error or redisplay
        //    model.AvailableDoctors = _doctors;
        //    model.AvailableMedications = _medications.Select(m => new SelectListItem
        //    {
        //        Value = m.MedicationId.ToString(),
        //        Text = m.Name
        //    }).ToList();

        //    if (!ModelState.IsValid)
        //    {
        //        model.Prescriptions = _prescriptions.OrderByDescending(p => p.PrescriptionDate).ToList();
        //        return View("Dashboard", model);
        //    }

        //    // Add each medication as a separate PrescriptionMock entry (simulate saving)
        //    foreach (var med in model.Medications)
        //    {
        //        _prescriptions.Add(new PrescriptionMock
        //        {
        //            Id = _prescriptions.Count + 1,
        //            PatientName = model.PatientIdNumber,
        //            DrugName = _medications.FirstOrDefault(x => x.MedicationId == med.MedicationId)?.Name ?? "Unknown",
        //            Dosage = med.Dosage,
        //            Quantity = med.Quantity,
        //            Instructions = med.Instructions,
        //            DoctorName = model.DoctorName,
        //            PrescriptionDate = model.PrescriptionDate,
        //            IsDispensed = false
        //        });
        //    }

        //    TempData["Success"] = "Prescription uploaded successfully!";
        //    return RedirectToAction("Dashboard");
        //}

        // Mark prescription as dispensed
        public IActionResult Dispense(int id)
        {
            var prescription = _prescriptions.FirstOrDefault(p => p.Id == id);
            if (prescription == null) return NotFound();

            if (!prescription.IsDispensed)
            {
                prescription.IsDispensed = true;
                TempData["Success"] = $"Prescription for {prescription.PatientName} marked as dispensed.";
            }

            return RedirectToAction("Dashboard");
        }

        public IActionResult PatientInfo()
        {
            return View();
        }
        public IActionResult UploadPrescription()
        {
            return View();
        }
        public IActionResult PrescriptionInbox()
        {
            return View();
        }
        public IActionResult DispenseNew()
        {
            return View();
        }


        public IActionResult CheckedOut()
        {
            return View();
        }

        public IActionResult AddDoctor()
        {
            return View();
        }
        public IActionResult NotifyCustomers()
        {
            return View();
        }
    }
}
