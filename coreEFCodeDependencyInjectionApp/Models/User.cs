namespace coreEFCodeDependencyInjectionApp.Models
{
    public class User
    {
        // Scalar Properties
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;

        // Navigation Properties
        public UserProfile? UserProfile { get; set; }
    }
}
