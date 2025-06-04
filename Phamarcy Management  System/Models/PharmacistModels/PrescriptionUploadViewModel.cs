using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Phamarcy_Management__System.Models.PharmacistModels
{


    public class PrescriptionUploadViewModel

    {
        public string PatientId { get; set; }
        public string MedicationName { get; set; }
        public List<PrescriptionViewModel> PendingPrescriptions { get; set; }
        public List<string> AvailableDoctors { get; set; } = new() { "Dr. Smith", "Dr. Jane", "Dr. Adams" };
        public List<SelectListItem> AvailableMedications { get; set; } = new()
    {
        new SelectListItem { Text = "Paracetamol", Value = "1" },
        new SelectListItem { Text = "Ibuprofen", Value = "2" },
        new SelectListItem { Text = "Amoxicillin", Value = "3" }
    };


        public List<MedicationInputModel> Medications { get; set; } = new List<MedicationInputModel>();
        public List<PrescriptionMock> Prescriptions { get; set; } = new()
    {
        new PrescriptionMock
        {
            Id = 1,
            PatientName = "John Doe",
            PatientIdNumber="0212123444083",
            DrugName = "Paracetamol",
            Dosage = "500mg",
            Quantity = 10,
            Instructions = "Take after meals",
            DoctorName = "Dr. Smith",
            PrescriptionDate = DateTime.Today.AddDays(-2),
            IsDispensed = false
        },
        new PrescriptionMock
        {
            Id = 2,
            PatientName = "Jane Doe",
            PatientIdNumber="0212123444083",
            DrugName = "Ibuprofen",
            Dosage = "200mg",
            Quantity = 20,
            Instructions = "Twice daily",
            DoctorName = "Dr. Jane",
            PrescriptionDate = DateTime.Today.AddDays(-1),
            IsDispensed = true
        }
    };
    }

    public class PrescriptionMock
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string PatientIdNumber { get; set; }  // ✅ CHANGED from double to string
        public string DrugName { get; set; }
        public string Dosage { get; set; }
        public int Quantity { get; set; }
        public string Instructions { get; set; }
        public string DoctorName { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public bool IsDispensed { get; set; }
    }


    public class MedicationInputModel
    {
        public int MedicationId { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public int Quantity { get; set; }
        public string Instructions { get; set; }
        public int Repeats { get; set; }
    }

}


