namespace Phamarcy_Management__System.Models.PharmacistModels
{
    public class PrescriptionViewModel
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DrugName { get; set; }
        public string Dosage { get; set; }
        public int Quantity { get; set; }
        public string Instructions { get; set; }
        public int Repeats { get; set; }
        public string DoctorName { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public bool IsDispensed { get; set; }
        public List<MedicationInputModel> Medications { get; set; }
    }

}
