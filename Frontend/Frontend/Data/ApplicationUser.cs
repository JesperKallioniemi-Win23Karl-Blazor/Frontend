using Microsoft.AspNetCore.Identity;

namespace Frontend.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? UserProfileId { get; set; }
        public UserProfile? UserProfile { get; set; }
        public string? UserAdressId { get; set; }
        public UserAdress? UserAdress { get; set; }
        
    }

}
