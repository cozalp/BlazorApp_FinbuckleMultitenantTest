using Microsoft.EntityFrameworkCore;
using Finbuckle.MultiTenant.EntityFrameworkCore;
using Finbuckle.MultiTenant.Abstractions;

namespace BlazorApp_FinbuckleMultitenantTest.Data
{
    public class ApplicationDbContext(
        IMultiTenantContextAccessor multiTenantContextAccessor,
        DbContextOptions<ApplicationDbContext> options) : MultiTenantIdentityDbContext<ApplicationUser>(multiTenantContextAccessor, options)
    {
    }
}
