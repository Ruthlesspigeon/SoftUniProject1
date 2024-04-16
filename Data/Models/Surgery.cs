using System;
using System.ComponentModel.DataAnnotations;
namespace EyeSurgeryClinic.Data.Models
{
    public class Surgery
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int SurgeryTypeId { get; set; }

        [Required]
        public int Accommodation { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Transfer { get; set; }
    }
}
