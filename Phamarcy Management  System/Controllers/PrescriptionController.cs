using Phamarcy_Management__System.Models;
using CustomerSubsystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class PrescriptionController : Controller
{
	// In-memory list for demo purposes
	private static List<PrescriptionUpload> _prescriptions = new List<PrescriptionUpload>();

    // Show Upload form
    public IActionResult Upload()
    {
        var model = new PrescriptionUploadViewModel();
        return View(model);
    }


    // Handle Upload POST
    [HttpPost]
	public IActionResult UploadPrescription(PrescriptionUploadViewModel model)
	{
		if (model?.UploadedFile == null || model.UploadedFile.Length == 0)
		{
			ModelState.AddModelError("", "Please select a PDF file to upload.");
			return View();
		}

		if (!model.UploadedFile.FileName.EndsWith(".pdf", System.StringComparison.OrdinalIgnoreCase))
		{
			ModelState.AddModelError("", "Only PDF files are allowed.");
			return View();
		}

		// Save file name and info to the in-memory list
		var newPrescription = new PrescriptionUpload
		{
			PrescriptionId = _prescriptions.Count > 0 ? _prescriptions.Max(p => p.PrescriptionId) + 1 : 1,
			PatientName = model.PatientName,
			FileName = model.UploadedFile.FileName,
			UploadDate = DateTime.Now,
			RepeatsLeft = 2,
			Status = "Pending"
		};

		_prescriptions.Add(newPrescription);

		TempData["Success"] = "Prescription uploaded successfully. You will be notified when ready.";
		return RedirectToAction(nameof(PrescriptionStatus));
	}

	// List all prescriptions
	public IActionResult PrescriptionStatus()
	{
		return View(_prescriptions);
	}

	// Delete prescription by id
	[HttpPost]
	public IActionResult DeletePrescription(int id)
	{
		var item = _prescriptions.FirstOrDefault(p => p.PrescriptionId == id);
		if (item != null)
		{
			_prescriptions.Remove(item);
			TempData["Success"] = "Prescription deleted.";
		}
		return RedirectToAction(nameof(PrescriptionStatus));
	}
}
