using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace SoftUniProject.Data
{
    public class Patient
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public decimal Diopters { get; set; }

        public int TransferID { get; set; }
        public Transfer Transfer { get; set; }

        public int AccommodationID { get; set; }
        public Accommodation Accommodation { get; set; }
    }
}
