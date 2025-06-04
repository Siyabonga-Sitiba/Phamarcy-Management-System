using WebApplication1.Models.Pharmacy;

namespace WebApplication1.Data
{
    public static class MockInventory
    {
        public static List<Medication> Medications { get; set; } = new List<Medication>();
    }
}
