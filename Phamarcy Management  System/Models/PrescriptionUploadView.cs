using System.ComponentModel.DataAnnotations;

namespace CustomerSubsystem.Models
{
    public class PrescriptionUploadViewModel
    {
        [Required]
        public string PatientName { get; set; }

        [Required]
        public IFormFile UploadedFile { get; set; }  // Must be IFormFile type!
    }


}
