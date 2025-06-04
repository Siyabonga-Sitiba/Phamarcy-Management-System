namespace WebApplication1.Models
{
    public class PrescriptionModel
    {
        public int Id { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string PdfFileName { get; set; }
        public List<MedicationEntry> Medications { get; set; } = new();
        public string Status { get; set; } = "Pending"; // New, Dispensed, Flag
    }
}
