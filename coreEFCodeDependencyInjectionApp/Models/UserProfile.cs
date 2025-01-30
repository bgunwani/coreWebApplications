using System.ComponentModel.DataAnnotations.Schema;

namespace coreEFCodeDependencyInjectionApp.Models
{
    public class UserProfile
    {
        // Scalar Properties
        public int UserProfileId { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        [ForeignKey("User")]
        public int UserId { get; set; }

        // Navigation Properties
        public User? User { get; set; }
    }
}
