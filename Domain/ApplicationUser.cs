using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }=string.Empty;
        public string LastName { get; set; }=string.Empty;
    }
}
