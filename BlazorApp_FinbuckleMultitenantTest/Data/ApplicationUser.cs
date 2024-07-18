using Finbuckle.MultiTenant;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp_FinbuckleMultitenantTest.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    [MultiTenant]
    public class ApplicationUser : IdentityUser
    {
    }

}
