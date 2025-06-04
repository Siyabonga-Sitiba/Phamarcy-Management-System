using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
namespace WebApplication1.Models
{
    public class MedicationViewModel
    {
        public string Name { get; set; }
        public string Dosage { get; set; }
        public int Quantity { get; set; }
        public string Instructions { get; set; }
        public int Repeats { get; set; }
    }
}

