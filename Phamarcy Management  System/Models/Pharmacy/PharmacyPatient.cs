using System;

namespace WebApplication1.Models.Pharmacy
{
    public class PharmacyPatient
    {
        public int PatientId { get; set; }  // Primary key
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Status { get; set; } = "Waiting";  // Default value
    }
}




