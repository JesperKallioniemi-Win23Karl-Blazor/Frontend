using Microsoft.AspNetCore.Identity;

namespace Frontend.Data
{
    public class UserProfile : IdentityUser
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? ProfilePicture { get; set; }
        public string? Bio { get; set; }
    }

}
