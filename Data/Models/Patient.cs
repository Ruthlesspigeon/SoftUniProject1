using System.ComponentModel.DataAnnotations;
namespace EyeSurgeryClinic.Data.Models
{
    public class Patient
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [Range(18, 60)]
        public int Age { get; set; }
    }
}
