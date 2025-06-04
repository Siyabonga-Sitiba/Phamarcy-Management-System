using System;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models.Pharmacy
{
    public class Medication
    {
        [Key]
        public int MedicationId { get; set; }
        public string MedicationName { get; set; }
        public string DosageForm{ get; set; }
        public DateTime ExpiryDate { get; set; }
        public int? Quantity { get; set; }
        public string Schedule { get; set; }
        public int? ReorderLevel { get; set; } = 10; // default reorder threshold
        [Required]
        public string Dosage { get; set; }
        public int Repeats { get; set; } = 0; // Number of times it can be refilled

        
    }

}
