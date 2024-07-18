using Finbuckle.MultiTenant.Abstractions;

namespace BlazorApp_FinbuckleMultitenantTest.Data
{
    public class AppTenantInfo : ITenantInfo
    {
        public string? Id { get; set; }

        public string? Identifier { get; set; }

        public string? Name { get; set; }

        public string? ChallengeScheme { get; set; }
    }
}
