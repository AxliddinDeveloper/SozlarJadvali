using System.ComponentModel.DataAnnotations;

namespace SozlarJadvali.Models.Admins
{
    public class Admin
    {
        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
