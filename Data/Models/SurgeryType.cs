namespace EyeSurgeryClinic.Data.Models
{
    public class SurgeryType
    {
        public int ID { get; set; }

        public string TypeOfSurgery { get; set; }

        public decimal Price { get; set; } = 0;
    }
}
