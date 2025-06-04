namespace Phamarcy_Management__System.Models
{
	public class PrescriptionUpload
	{
		public int PrescriptionId { get; set; }  // int for simplicity
		public string PatientName { get; set; }
		public string FileName { get; set; }
		public string Status { get; set; } = "Pending"; // default status

		public int RepeatsLeft { get; set; } = 0;
		public DateTime UploadDate { get; set; }
	}
}

