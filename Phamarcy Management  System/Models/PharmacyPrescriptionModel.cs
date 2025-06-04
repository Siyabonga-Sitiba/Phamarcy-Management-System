using System;
using System.ComponentModel.DataAnnotations;

public class PharmacyPrescriptionModel
{
    // Patient Info
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    [Required] public string Relation { get; set; }
    [Required, EmailAddress] public string Email { get; set; }
    [Required] public string Phone { get; set; }
    public string Provider { get; set; }
    [DataType(DataType.Date)] public DateTime? LastAppointment { get; set; }

    // Prescription Info
    [Required] public string BrandName { get; set; }
    public string GenericName { get; set; }
    public string Form { get; set; }
    [Required] public string Dosage { get; set; }
    public string Frequency { get; set; }
    [DataType(DataType.Date)] public DateTime? LastTaken { get; set; }
    [DataType(DataType.Date)] public DateTime? RunOutDate { get; set; }
    public string PharmacyName { get; set; }
    public string PharmacyPhone { get; set; }
    public string PharmacyAddress { get; set; }

    public string Comments { get; set; }
}
