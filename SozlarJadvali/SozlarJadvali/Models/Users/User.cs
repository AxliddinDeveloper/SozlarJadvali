using System.ComponentModel.DataAnnotations;

namespace SozlarJadvali.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Message { get; set; } = string.Empty;
    }
}
