using Microsoft.AspNetCore.Identity;
namespace EyeSurgeryClinic.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserName { get; set;}
    }
}
