using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinder.Infrastructure.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(CreateRoles());
        }

        private List<IdentityRole> CreateRoles()
        {
            var roles = new List<IdentityRole>();

            var role = new IdentityRole()
            {
                Id = "148e3a33-ff37-4df0-a66f-d26416e5c981",
                Name = "Administrator",
                NormalizedName = "administrator"
            };

            roles.Add(role);

            role = new IdentityRole()
            {
                Id = "081218dd-1be7-45e9-a153-eb73758c9f56",
                Name = "Employer",
                NormalizedName = "employer"
            };

            roles.Add(role);

            role = new IdentityRole()
            {
                Id = "68dc4906-58cf-4d2b-9683-bf11ea7d4afa",
                Name = "Candidate",
                NormalizedName = "candidate"
            };

            roles.Add(role);
            return roles;
        }
    }
}
